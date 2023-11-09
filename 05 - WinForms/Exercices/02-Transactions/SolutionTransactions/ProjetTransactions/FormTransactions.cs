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
            string name = this.textBoxName.Text;

            if (name.Length > 0 && !Verifier.IsCorrectName(name))
            {
                MessageBox.Show(
                    "Veuillez entrer un nom valide",
                    "Erreur",
                    MessageBoxButtons.OK
                    );
            }
        }

        private void textBoxDate_Leave(object sender, EventArgs e)
        {
            string date = this.textBoxDate.Text;

            if (date.Length > 0 && !Verifier.IsCorrectDate(date))
            {
                MessageBox.Show(
                    "Veuillez entrer une date valide",
                    "Erreur",
                    MessageBoxButtons.OK
                    );
            }
        }

        private void textBoxAmount_Leave(object sender, EventArgs e)
        {
            string amount = this.textBoxAmount.Text;

            if (amount.Length > 0 && !Verifier.IsCorrectAmount(amount))
            {
                MessageBox.Show(
                    "Veuillez entrer un montant valide",
                    "Erreur",
                    MessageBoxButtons.OK
                    );
            }
        }

        private void textBoxZipcode_Leave(object sender, EventArgs e)
        {
            string zipcode = this.textBoxZipcode.Text;

            if (zipcode.Length > 0 && !Verifier.IsCorrectZipcode(zipcode))
            {
                MessageBox.Show(
                    "Veuillez entrer un code postal valide",
                    "Erreur",
                    MessageBoxButtons.OK
                    );
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            this.VerifyButtonValidate();
        }

        private bool NameIsSendable()
        {
            string name = this.textBoxName.Text;
            return name.Length > 0 && Verifier.IsCorrectName(name);
        }

        private bool DateIsSendable()
        {
            string date = this.textBoxDate.Text;
            return date.Length > 0 && Verifier.IsCorrectDate(date);
        }

        private bool AmountIsSendable()
        {
            string amount = this.textBoxAmount.Text;
            return amount.Length > 0 && Verifier.IsCorrectAmount(amount);
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

        private void buttonErase_Click(object sender, EventArgs e)
        {
            this.Erase(this.textBoxName);
            this.Erase(this.textBoxDate);
            this.Erase(this.textBoxAmount);
            this.Erase(this.textBoxZipcode);

            this.VerifyButtonValidate();
        }

        private void Erase(TextBox _textBox)
        {
            _textBox.Text = "";
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            if (this.TransactionIsSendable())
            {

                // Ouvrir fenêtre de confirmation

            }
        }
    }
}
