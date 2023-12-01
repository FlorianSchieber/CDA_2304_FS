using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL_Repayment;

namespace ProjectRepayment
{
    public partial class FormRepayment : Form
    {
        private static Dictionary<string, Compound> compoundLinks = new Dictionary<string, Compound>
        {
            { "Mensuelle", Compound.Monthly },
            { "Bimestrielle", Compound.Bimonthly },
            { "Trimestrielle", Compound.Quarterly },
            { "Semestrielle", Compound.SemiAnnually },
            { "Annuelle", Compound.Annually }
        };

        private Repayment? inoutRepayment;
        private Repayment internalRepayment;
        private bool save;

        // Constructors

        public FormRepayment()
        {
            InitializeComponent();
            this.inoutRepayment = new Repayment();
            this.internalRepayment = new Repayment();
            this.save = false;
            this.GenerateComboBoxCompoundItems();
            this.RefreshFromInternalRepayment();
        }

        public FormRepayment(Repayment _repayment)
        {
            InitializeComponent();
            this.inoutRepayment = _repayment;
            this.internalRepayment = new Repayment(_repayment);
            this.save = false;
            this.GenerateComboBoxCompoundItems();
            this.RefreshFromInternalRepayment();
        }

        // Getters

        public Repayment InoutRepayment { get { return this.inoutRepayment; } }
        public Repayment InternalRepayment { get { return this.internalRepayment; } }

        // Methods

        public void GenerateComboBoxCompoundItems()
        {
            foreach (KeyValuePair<string, Compound> compoundLink in FormRepayment.compoundLinks)
            {
                this.comboBoxCompound.Items.Add(compoundLink.Key);
            }
        }

        public void RefreshFromInternalRepayment()
        {
            this.textBoxName.Text = this.internalRepayment.Name;
            this.maskedTextBoxLoanBalance.Text = this.internalRepayment.LoanBalance.ToString();
            this.numericUpDownRepaymentTime.Value = this.internalRepayment.RepaymentTimeInMonth();
            this.numericUpDownRepaymentTime.Increment = (int)this.internalRepayment.Compound;
            this.hScrollBarRepaymentTime.Value = this.internalRepayment.RepaymentTimeInMonth();

            switch (this.internalRepayment.AnnualInterestRate)
            {
                case 0.07:
                    this.radioButton7Percent.Checked = true;
                    break;

                case 0.08:
                    this.radioButton8Percent.Checked = true;
                    break;

                case 0.09:
                    this.radioButton9Percent.Checked = true;
                    break;
            }

            foreach (KeyValuePair<string, Compound> compoundLink in FormRepayment.compoundLinks)
            {
                if (this.internalRepayment.Compound == compoundLink.Value)
                {
                    this.comboBoxCompound.SelectedItem = compoundLink.Key;
                }
            }

            this.DisplayRepaymentValue();
        }

        public bool StoreToInternalRepayment()
        {
            if (this.IsValidRepayment())
            {
                string name = this.textBoxName.Text;
                int loanBalance;
                int.TryParse(this.maskedTextBoxLoanBalance.Text, out loanBalance);
                string stringCompound = (string)this.comboBoxCompound.SelectedItem;
                Compound compound = FormRepayment.compoundLinks[stringCompound];
                int repaymentNumber = (int)Math.Ceiling(this.numericUpDownRepaymentTime.Value / (int)compound);

                double annualInterestRate;

                if (this.radioButton7Percent.Checked)
                {
                    annualInterestRate = 0.07;
                }
                else if (this.radioButton8Percent.Checked)
                {
                    annualInterestRate = 0.08;
                }
                else if (this.radioButton9Percent.Checked)
                {
                    annualInterestRate = 0.09;
                }
                else
                {
                    annualInterestRate = 0.07;
                }

                this.internalRepayment = new Repayment(name, loanBalance, repaymentNumber, compound, annualInterestRate);

                return true;
            }

            return false;
        }

        public void DisplayRepaymentValue()
        {
            if (this.IsValidRepayment())
            {
                this.textBoxRepayment.Text = this.RepaymentValueToString(this.internalRepayment.RepaymentValue());
            }
            else
            {
                this.textBoxRepayment.Text = "";
            }
        }

        public string RepaymentValueToString(double _repaymentValue)
        {
            return _repaymentValue.ToString("#.##");
        }

        // Verifiers

        public bool IsValidLoanBalance()
        {
            string pattern = @"^[0-9]+$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(this.maskedTextBoxLoanBalance.Text);
        }

        public bool IsValidRepaymentTime()
        {
            return !string.IsNullOrEmpty(this.numericUpDownRepaymentTime.Value.ToString());
        }

        public bool IsValidCompound()
        {
            return this.comboBoxCompound.SelectedIndex != -1;
        }

        public bool IsValidAnnualInterestRate()
        {
            return this.radioButton7Percent.Checked ||
                this.radioButton8Percent.Checked ||
                this.radioButton9Percent.Checked;
        }

        public bool IsValidRepayment()
        {
            return this.IsValidLoanBalance() &&
                this.IsValidRepaymentTime() &&
                this.IsValidCompound() &&
                this.IsValidAnnualInterestRate();
        }

        // Events

        private void maskedTextBoxLoanBalance_TextChanged(object sender, EventArgs e)
        {
            if (this.IsValidLoanBalance())
            {
                this.errorProviderLoanBalance.SetError(this.labelCurrency, "");
                this.StoreToInternalRepayment();
            }
            else
            {
                this.errorProviderLoanBalance.SetError(this.labelCurrency, "Veuillez entrer un montant valide");
            }

            this.DisplayRepaymentValue();
        }

        private void maskedTextBoxLoanBalance_Leave(object sender, EventArgs e)
        {
            this.StoreToInternalRepayment();
            this.DisplayRepaymentValue();
        }

        private void hScrollBarRepaymentTime_Scroll(object sender, ScrollEventArgs e)
        {
            this.numericUpDownRepaymentTime.Value = this.hScrollBarRepaymentTime.Value;
        }

        private void hScrollBarRepaymentTime_ValueChanged(object sender, EventArgs e)
        {
            this.StoreToInternalRepayment();
            this.DisplayRepaymentValue();
        }

        private void numericUpDownRepaymentTime_ValueChanged(object sender, EventArgs e)
        {
            this.hScrollBarRepaymentTime.Value = (int)this.numericUpDownRepaymentTime.Value;
            this.StoreToInternalRepayment();
            this.DisplayRepaymentValue();
        }

        private void comboBoxCompound_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.StoreToInternalRepayment();
            this.DisplayRepaymentValue();
        }

        private void radioButton7Percent_CheckedChanged(object sender, EventArgs e)
        {
            this.StoreToInternalRepayment();
            this.DisplayRepaymentValue();
        }

        private void radioButton8Percent_CheckedChanged(object sender, EventArgs e)
        {
            this.StoreToInternalRepayment();
            this.DisplayRepaymentValue();
        }

        private void radioButton9Percent_CheckedChanged(object sender, EventArgs e)
        {
            this.StoreToInternalRepayment();
            this.DisplayRepaymentValue();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.IsValidRepayment())
            {
                this.save = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Le formulaire n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRepayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.save)
            {
                this.inoutRepayment = this.internalRepayment;
            }
            
        }
    }
}
