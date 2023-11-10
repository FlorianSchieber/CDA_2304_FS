using System;
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

namespace ProjetTransactions
{
    public partial class FormTransactions : Form
    {
        public FormTransactions()
        {
            InitializeComponent();
        }

        private void FormTransactions_Load(object sender, EventArgs e)
        {

        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (this.NameIsInvalid())
            {
                this.errorProviderName.SetError(this.textBoxName, "Le nom est invalide");
            }
        }

        private void textBoxDate_Leave(object sender, EventArgs e)
        {
            if (this.DateIsInvalid())
            {
                this.errorProviderDate.SetError(this.labelDateTip, "La date est invalide");
            }
        }

        private void textBoxAmount_Leave(object sender, EventArgs e)
        {
            if (this.AmountIsInvalid())
            {
                this.errorProviderAmount.SetError(this.labelCurrency, "Le montant est invalide");
            }
        }

        private void textBoxZipcode_Leave(object sender, EventArgs e)
        {
            if (this.ZipcodeIsInvalid())
            {
                this.errorProviderZipcode.SetError(this.textBoxZipcode, "Le code postal est invalide");
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (!this.NameIsInvalid())
            {
                this.errorProviderName.SetError(this.textBoxName, "");
            }
            this.VerifyButtonValidate();
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            if (!this.DateIsInvalid())
            {
                this.errorProviderDate.SetError(this.labelDateTip, "");
            }
            this.VerifyButtonValidate();
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            if (!this.AmountIsInvalid())
            {
                this.errorProviderAmount.SetError(this.labelCurrency, "");
            }
            this.VerifyButtonValidate();
        }

        private void textBoxZipcode_TextChanged(object sender, EventArgs e)
        {
            if (!this.ZipcodeIsInvalid())
            {
                this.errorProviderZipcode.SetError(this.textBoxZipcode, "");
            }
            this.VerifyButtonValidate();
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            this.Erase(this.textBoxName);
            this.Erase(this.textBoxDate);
            this.Erase(this.textBoxAmount);
            this.Erase(this.textBoxZipcode);

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

                // Ouvrir fenêtre de confirmation

            }
        }

        private bool NameIsInvalid()
        {
            string name = this.textBoxName.Text;
            return name.Length > 0 && !Verifier.IsCorrectName(name);
        }

        private bool NameIsSendable()
        {
            string name = this.textBoxName.Text;
            return name.Length > 0 && Verifier.IsCorrectName(name);
        }

        private bool DateIsInvalid()
        {
            string date = this.textBoxDate.Text;
            return date.Length > 0 && !Verifier.IsCorrectDate(date);
        }

        private bool DateIsSendable()
        {
            string date = this.textBoxDate.Text;
            return date.Length > 0 && Verifier.IsCorrectDate(date);
        }

        private bool AmountIsInvalid()
        {
            string amount = this.textBoxAmount.Text;
            return amount.Length > 0 && !Verifier.IsCorrectAmount(amount);
        }

        private bool AmountIsSendable()
        {
            string amount = this.textBoxAmount.Text;
            return amount.Length > 0 && Verifier.IsCorrectAmount(amount);
        }

        private bool ZipcodeIsInvalid()
        {
            string zipcode = this.textBoxZipcode.Text;
            return zipcode.Length > 0 && !Verifier.IsCorrectZipcode(zipcode);
        }

        private bool ZipcodeIsSendable()
        {
            string zipcode = this.textBoxZipcode.Text;
            return zipcode.Length > 0 && Verifier.IsCorrectZipcode(zipcode);
        }

        private bool TransactionIsSendable()
        {
            return (
                NameIsSendable() &&
                DateIsSendable() &&
                AmountIsSendable() &&
                ZipcodeIsSendable()
                );
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

        private void Erase(TextBox _textBox)
        {
            _textBox.Text = "";
        }
    }
}
