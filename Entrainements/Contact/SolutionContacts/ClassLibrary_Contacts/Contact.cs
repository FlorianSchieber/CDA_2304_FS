using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }

        // Getters

        public string FirstName { get => this.firstName; }
        public string LastName { get => this.lastName; }
        public DateTime BirthDate { get => this.birthDate; }
        public string Address { get => this.address; }
        public string ZipCode { get => this.zipCode; }
        private string PhoneNumber { get => this.phoneNumber; }
        private string Email { get => this.email; }

        
    }
}
