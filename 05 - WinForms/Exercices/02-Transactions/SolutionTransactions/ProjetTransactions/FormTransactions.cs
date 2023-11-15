using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CL_Verifier;
using CL_Transaction;
using System.Globalization;

namespace ProjetTransactions
{
    public partial class FormTransactions : Form
    {
        private Transaction currentTransaction;

        public FormTransactions()
        {
            InitializeComponent();
            this.currentTransaction = null;
        }

        public FormTransactions(Transaction _currentTransaction)
        {
            InitializeComponent();
            this.currentTransaction = _currentTransaction;
            this.textBoxName.Text = this.currentTransaction.Name;
            this.textBoxDate.Text = Verifier.DateToString(this.currentTransaction.Date);
            this.textBoxAmount.Text = Verifier.AmountToString(this.currentTransaction.Amount);
            this.textBoxZipcode.Text = this.currentTransaction.Zipcode;
        }

        public Transaction CurrentTransaction { get => this.currentTransaction; }

        private void FormTransactions_Load(object sender, EventArgs e)
        {

        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            string name = this.textBoxName.Text;

            if (Verifier.IsEmpty(name))
            {
                this.errorProviderName.SetError(this.textBoxName, "Le nom est obligatoire");
            }
            else if (Verifier.IsValidName(name))
            {
                if (!Verifier.IsShortName(name))
                {
                    this.errorProviderName.SetError(this.textBoxName, "Le nom doit faire 30 caractères maximum");
                }
            }
            else
            {
                this.errorProviderName.SetError(this.textBoxName, "Le nom n'est pas au bon format");
            }

            this.VerifyButtonValidate();
        }

        private void textBoxDate_Leave(object sender, EventArgs e)
        {
            string dateString = this.textBoxDate.Text;

            if (Verifier.IsEmpty(dateString))
            {
                this.errorProviderDate.SetError(this.labelDateTip, "La date est obligatoire");
            }
            else if (Verifier.IsValidDate(dateString))
            {
                DateTime tempDate = Verifier.ToDate(dateString);

                if (!Verifier.IsFutureDate(tempDate))
                {
                    this.errorProviderDate.SetError(this.labelDateTip, "La date doit être dans le futur");
                }
            }
            else
            {
                this.errorProviderDate.SetError(this.labelDateTip, "La date n'est pas au bon format");
            }

            this.VerifyButtonValidate();
        }

        private void textBoxAmount_Leave(object sender, EventArgs e)
        {
            string amountString = this.textBoxAmount.Text;

            if (Verifier.IsEmpty(amountString))
            {
                this.errorProviderAmount.SetError(this.labelCurrency, "Le montant est obligatoire");
            }
            else if (Verifier.IsValidAmount(amountString))
            {
                double tempAmount = Verifier.ToAmount(amountString);

                if (Verifier.IsNegative(tempAmount))
                {
                    this.errorProviderAmount.SetError(this.labelCurrency, "Le montant doit être positif");
                }
            }
            else
            {
                this.errorProviderAmount.SetError(this.labelCurrency, "Le montant n'est pas au bon format");
            }

            this.VerifyButtonValidate();
        }

        private void textBoxZipcode_Leave(object sender, EventArgs e)
        {
            string zipcode = this.textBoxZipcode.Text;

            if (Verifier.IsEmpty(zipcode))
            {
                this.errorProviderZipcode.SetError(this.textBoxZipcode, "Le code postal est obligatoire");
            }
            else if (!Verifier.IsValidZipcode(zipcode))
            {
                this.errorProviderZipcode.SetError(this.textBoxZipcode, "Le code postal n'est pas au bon format");
            }

            this.VerifyButtonValidate();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            this.errorProviderName.SetError(this.textBoxName, "");
            this.VerifyButtonValidate();
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            this.errorProviderDate.SetError(this.labelDateTip, "");
            this.VerifyButtonValidate();
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            this.errorProviderAmount.SetError(this.labelCurrency, "");
            this.VerifyButtonValidate();
        }

        private void textBoxZipcode_TextChanged(object sender, EventArgs e)
        {
            this.errorProviderZipcode.SetError(this.textBoxZipcode, "");
            this.VerifyButtonValidate();
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            this.EraseTextBoxes();

            this.errorProviderName.SetError(this.textBoxName, "");
            this.errorProviderDate.SetError(this.labelDateTip, "");
            this.errorProviderAmount.SetError(this.labelCurrency, "");
            this.errorProviderZipcode.SetError(this.textBoxZipcode, "");

            this.VerifyButtonValidate();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            if (this.TransactionIsSendable())
            {
                string name = this.textBoxName.Text;
                string dateString = this.textBoxDate.Text;
                string amountString = this.textBoxAmount.Text;
                string zipcode = this.textBoxZipcode.Text;

                if (this.TransactionIsSendable())
                {
                    CL_Transaction.Transaction newTransaction = new CL_Transaction.Transaction(name, dateString, amountString, zipcode);

                    this.currentTransaction = newTransaction;

                    MessageBox.Show(newTransaction.ToString(), "Succès", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.EraseTextBoxes();
                }
            }
        }

        private bool NameIsSendable()
        {
            string name = this.textBoxName.Text;
            if (!Verifier.IsEmpty(name))
            {
                if (Verifier.IsValidName(name))
                {
                    return Verifier.IsShortName(name);
                }
            }

            return false;
        }

        private bool DateIsSendable()
        {
            string dateString = this.textBoxDate.Text;
            if (!Verifier.IsEmpty(dateString))
            {
                if (Verifier.IsValidDate(dateString))
                {
                    DateTime tempDate = Verifier.ToDate(dateString);

                    return Verifier.IsFutureDate(tempDate);
                }
            }

            return false;
        }

        private bool AmountIsSendable()
        {
            string amountString = this.textBoxAmount.Text;

            if (!Verifier.IsEmpty(amountString))
            {
                if (Verifier.IsValidAmount(amountString))
                {
                    double tempAmount = Verifier.ToAmount(amountString);

                    return !Verifier.IsNegative(tempAmount);
                }
            }

            return false;
        }

        private bool ZipcodeIsSendable()
        {
            string zipcode = this.textBoxZipcode.Text;

            if (!Verifier.IsEmpty(zipcode))
            {
                return Verifier.IsValidZipcode(zipcode);
            }

            return false;
        }

        private bool TransactionIsSendable()
        {
            return
                NameIsSendable() &&
                DateIsSendable() &&
                AmountIsSendable() &&
                ZipcodeIsSendable();
        }

        private void VerifyButtonValidate()
        {

            if (this.TransactionIsSendable())
            {
                this.buttonValidate.Enabled = true;
            }
            else
            {
                this.buttonValidate.Enabled = false;
            }

        }

        private void EraseTextBoxes()
        {
            textBoxName.Text = "";
            textBoxDate.Text = "";
            textBoxAmount.Text = "";
            textBoxZipcode.Text = "";
        }

        private void FormTransactions_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous fermer l'application ?", "Fin d'application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
