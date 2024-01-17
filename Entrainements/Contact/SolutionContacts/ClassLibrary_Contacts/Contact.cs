using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_ContactVerifier;

namespace ClassLibrary_Contacts
{
    public class Contact
    {
        // Attributes

        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string address;
        private string zipCode;
        private string phoneNumber;
        private string email;

        // Constructors

        public Contact(string firstName, string lastName, DateTime birthDate, string address, string zipCode, string phoneNumber, string email)
        {
            if(
                ContactVerifier.IsValidFirstName(firstName) &&
                ContactVerifier.IsValidLastName(lastName) &&
                ContactVerifier.IsValidBirthDate(birthDate) &&
                ContactVerifier.IsValidZipCode(zipCode) &&
                ContactVerifier.IsValidPhoneNumber(phoneNumber) &&
                ContactVerifier.IsValidEmail(email)
            )
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.birthDate = birthDate;
                this.address = address;
                this.zipCode = zipCode;
                this.phoneNumber = phoneNumber;
                this.email = email;
            }
            else
            {
                throw new Exception("Invalid Contact");
            }
        }

        // Getters

        public string FirstName { get => this.firstName; }
        public string LastName { get => this.lastName; }
        public DateTime BirthDate { get => this.birthDate; }
        public string Address { get => this.address; }
        public string ZipCode { get => this.zipCode; }
        public string PhoneNumber { get => this.phoneNumber; }
        public string Email { get => this.email; }

        
    }
}
