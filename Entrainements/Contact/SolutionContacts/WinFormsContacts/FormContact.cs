using ClassLibrary_Contacts;
using ClassLibrary_ContactVerifier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsContacts
{
    public partial class FormContact : Form
    {
        private Contact storedContact;

        public FormContact()
        {
            InitializeComponent();

            this.storedContact = null;

            this.RefreshButtonValidate();
        }

        public FormContact(Contact contact)
        {
            InitializeComponent();

            this.storedContact = contact;

            if (this.storedContact != null)
            {
                this.textBoxFirstName.Text = storedContact.FirstName;
                this.textBoxLastName.Text = storedContact.LastName;
                this.textBoxBirthDate.Text = ContactConverter.DateToString(storedContact.BirthDate);
                this.textBoxAddress.Text = storedContact.Address;
                this.textBoxZipCode.Text = storedContact.ZipCode;
                this.textBoxPhoneNumber.Text = storedContact.PhoneNumber;
                this.textBoxEmail.Text = storedContact.Email;

                this.Text = "Edition de contact";
            }

            this.RefreshButtonValidate();
        }

        public Contact StoredContact { get { return this.storedContact; } }

        public void RefreshButtonValidate()
        {
            if (this.IsSendableContact())
            {
                this.buttonValidate.Enabled = true;
            }
            else
            {
                this.buttonValidate.Enabled = false;
            }
        }

        public bool IsSendableContact()
        {
            return this.IsSendableFirstName() &&
                this.IsSendableLastName() &&
                this.IsSendableBirthDate() &&
                this.IsSendableAddress() &&
                this.IsSendableZipCode() &&
                this.IsSendablePhoneNumber() &&
                this.IsSendableEmail();
        }

        public bool IsSendableFirstName()
        {
            return ContactVerifier.IsValidFirstName(this.textBoxFirstName.Text);
        }

        public bool IsSendableLastName()
        {
            return ContactVerifier.IsValidLastName(this.textBoxLastName.Text);
        }

        public bool IsSendableBirthDate()
        {
            return ContactVerifier.IsValidBirthDate(this.textBoxBirthDate.Text);
        }

        public bool IsSendableAddress()
        {
            return ContactVerifier.IsValidAddress(this.textBoxAddress.Text);
        }

        public bool IsSendableZipCode()
        {
            return ContactVerifier.IsValidZipCode(this.textBoxZipCode.Text);
        }

        public bool IsSendablePhoneNumber()
        {
            return ContactVerifier.IsValidPhoneNumber(this.textBoxPhoneNumber.Text);
        }

        public bool IsSendableEmail()
        {
            return ContactVerifier.IsValidEmail(this.textBoxEmail.Text);
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            if (this.IsSendableContact())
            {
                string firstName = this.textBoxFirstName.Text;
                string lastName = this.textBoxLastName.Text;
                DateTime birthDate = ContactConverter.StringToDate(this.textBoxBirthDate.Text);
                string address = this.textBoxAddress.Text;
                string zipCode = this.textBoxZipCode.Text;
                string phoneNumber = this.textBoxPhoneNumber.Text;
                string email = this.textBoxEmail.Text;

                this.storedContact = new Contact(firstName, lastName, birthDate, address, zipCode, phoneNumber, email);
                this.Close();
            }
            else
            {
                MessageBox.Show("La saisie est invalide.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            if (this.IsSendableFirstName())
            {
                this.errorProviderFirstName.SetError(this.textBoxFirstName, string.Empty);
            }
            this.RefreshButtonValidate();
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            if (this.IsSendableLastName())
            {
                this.errorProviderLastName.SetError(this.textBoxLastName, string.Empty);
            }
            this.RefreshButtonValidate();
        }

        private void textBoxBirthDate_TextChanged(object sender, EventArgs e)
        {
            if (this.IsSendableBirthDate())
            {
                this.errorProviderBirthDate.SetError(this.textBoxBirthDate, string.Empty);
            }
            this.RefreshButtonValidate();
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            if (this.IsSendableAddress())
            {
                this.errorProviderAddress.SetError(this.textBoxAddress, string.Empty);
            }
            this.RefreshButtonValidate();
        }

        private void textBoxZipCode_TextChanged(object sender, EventArgs e)
        {
            if (this.IsSendableZipCode())
            {
                this.errorProviderZipCode.SetError(this.textBoxZipCode, string.Empty);
            }
            this.RefreshButtonValidate();
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (this.IsSendablePhoneNumber())
            {
                this.errorProviderPhoneNumber.SetError(this.textBoxPhoneNumber, string.Empty);
            }
            this.RefreshButtonValidate();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (this.IsSendableEmail())
            {
                this.errorProviderEmail.SetError(this.textBoxEmail, string.Empty);
            }
            this.RefreshButtonValidate();
        }

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            string firstName = this.textBoxFirstName.Text;

            if (!ContactVerifier.IsNotVoid(firstName))
            {
                this.errorProviderFirstName.SetError(this.textBoxFirstName, "Veuillez saisir un prénom");
            }
            else if (!ContactVerifier.IsFormattedFirstName(firstName))
            {
                this.errorProviderFirstName.SetError(this.textBoxFirstName, "Le prénom doit commencer par une majuscule et ne contenir que des lettres et des tirets.");
            }
            else if (!ContactVerifier.IsShortFirstName(firstName))
            {
                this.errorProviderFirstName.SetError(this.textBoxFirstName, "le prénom doit être au maximum de " + ContactVerifier.FIRST_NAME_MAX_LENGTH + " caractères.");
            }
            else
            {
                this.errorProviderFirstName.SetError(this.textBoxFirstName, string.Empty);
            }
        }

        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            string lastName = this.textBoxLastName.Text;

            if (!ContactVerifier.IsNotVoid(lastName))
            {
                this.errorProviderLastName.SetError(this.textBoxLastName, "Veuillez saisir un nom de famille");
            }
            else if (!ContactVerifier.IsFormattedFirstName(lastName))
            {
                this.errorProviderLastName.SetError(this.textBoxLastName, "Le nom de famille doit commencer par une majuscule et ne contenir que des lettres et des tirets.");
            }
            else if (!ContactVerifier.IsShortFirstName(lastName))
            {
                this.errorProviderLastName.SetError(this.textBoxLastName, "le nom de famille doit être au maximum de " + ContactVerifier.LAST_NAME_MAX_LENGTH + " caractères.");
            }
            else
            {
                this.errorProviderLastName.SetError(this.textBoxLastName, string.Empty);
            }
        }

        private void textBoxBirthDate_Leave(object sender, EventArgs e)
        {
            string birthDateString = this.textBoxBirthDate.Text;

            if (!ContactVerifier.IsNotVoid(birthDateString))
            {
                this.errorProviderBirthDate.SetError(this.textBoxBirthDate, "Veuillez entrer une date");
            }
            else if (!ContactVerifier.IsFormattedBirthDate(birthDateString))
            {
                this.errorProviderBirthDate.SetError(this.textBoxBirthDate, "Veuillez entrer une date valide au format jj/mm/aaaa");
            }
            else
            {
                DateTime birthDate = ContactConverter.StringToDate(birthDateString);

                if (!ContactVerifier.IsMajorBirthDate(birthDate))
                {
                    this.errorProviderBirthDate.SetError(this.textBoxBirthDate, "Le contact doit être majeur");
                }
                else
                {
                    this.errorProviderBirthDate.SetError(this.textBoxBirthDate, string.Empty);
                }
            }
        }

        private void textBoxAddress_Leave(object sender, EventArgs e)
        {
            string address = this.textBoxAddress.Text;

            if (!ContactVerifier.IsNotVoid(address))
            {
                this.errorProviderAddress.SetError(this.textBoxAddress, "Veuillez entrer une adresse");
            }
            else
            {
                this.errorProviderAddress.SetError(this.textBoxAddress, string.Empty);
            }
        }

        private void textBoxZipCode_Leave(object sender, EventArgs e)
        {
            string zipCode = this.textBoxZipCode.Text;

            if (!ContactVerifier.IsNotVoid(zipCode))
            {
                this.errorProviderZipCode.SetError(this.textBoxZipCode, "Veuillez entrer un code postal");
            }
            else if (!ContactVerifier.IsFormattedZipCode(zipCode))
            {
                this.errorProviderZipCode.SetError(this.textBoxZipCode, "Le code postal ne doit être composé que de chiffres");
            }
            else if (!ContactVerifier.IsGoodLengthZipCode(zipCode))
            {
                this.errorProviderZipCode.SetError(this.textBoxZipCode, "Le code postal doit faire " + ContactVerifier.ZIP_CODE_LENGTH + " chiffres exactement");
            }
            else
            {
                this.errorProviderZipCode.SetError(this.textBoxZipCode, string.Empty);
            }
        }

        private void textBoxPhoneNumber_Leave(object sender, EventArgs e)
        {
            string phoneNumber = this.textBoxPhoneNumber.Text;

            if (!ContactVerifier.IsNotVoid(phoneNumber))
            {
                this.errorProviderPhoneNumber.SetError(this.textBoxPhoneNumber, "Veuillez entrer un numéro de téléphone");
            }
            else if (!ContactVerifier.IsFormattedPhoneNumber(phoneNumber))
            {
                this.errorProviderPhoneNumber.SetError(this.textBoxPhoneNumber, "Le numéro doit être composé de chiffres, éventuellement d'espaces et/ou de points");
            }
            else
            {
                this.errorProviderPhoneNumber.SetError(this.textBoxPhoneNumber, string.Empty);
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            string email = this.textBoxEmail.Text;

            if (!ContactVerifier.IsNotVoid(email))
            {
                this.errorProviderEmail.SetError(this.textBoxEmail, "Veuillez entrer une adresse email");
            }
            else if (!ContactVerifier.IsFormattedEmail(email))
            {
                this.errorProviderEmail.SetError(this.textBoxEmail, "Veuillez entrer une adresse email valide");
            }
            else
            {
                this.errorProviderEmail.SetError(this.textBoxEmail, string.Empty);
            }

        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            this.textBoxFirstName.Text = string.Empty;
            this.textBoxLastName.Text = string.Empty;
            this.textBoxBirthDate.Text = string.Empty;
            this.textBoxAddress.Text = string.Empty;
            this.textBoxZipCode.Text = string.Empty;
            this.textBoxPhoneNumber.Text = string.Empty;
            this.textBoxEmail.Text = string.Empty;

            this.errorProviderFirstName.SetError(this.textBoxFirstName, string.Empty);
            this.errorProviderLastName.SetError(this.textBoxLastName, string.Empty);
            this.errorProviderBirthDate.SetError(this.textBoxBirthDate, string.Empty);
            this.errorProviderAddress.SetError(this.textBoxAddress, string.Empty);
            this.errorProviderZipCode.SetError(this.textBoxZipCode, string.Empty);
            this.errorProviderPhoneNumber.SetError(this.textBoxPhoneNumber, string.Empty);
            this.errorProviderEmail.SetError(this.textBoxEmail, string.Empty);
        }
    }
}
