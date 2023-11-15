using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_Verifier;

namespace CL_Transaction
{
    [Serializable]
    public class Transaction
    {
        private string name;
        private DateTime date;
        private double amount;
        private string zipcode;

        public Transaction(string _name, string _dateString, string _amountString, string _zipcode)
        {

            if (!Verifier.IsEmpty(_name) && Verifier.IsValidName(_name)) {
                if (Verifier.IsShortName(_name)) {
                    this.name = _name;
                }
                else
                {
                    throw new Exception("No sendable transaction name : 30 characters maximum");
                }
            }
            else
            {
                throw new Exception("No sendable transaction name : incorrect format");
            }

            if (!Verifier.IsEmpty(_dateString) && Verifier.IsValidDate(_dateString))
            {
                DateTime tempDate = Verifier.ToDate(_dateString);
                
                if(Verifier.IsFutureDate(tempDate))
                {
                    this.date = tempDate;
                }
                else
                {
                    throw new Exception("No sendable transaction date : not in future");
                }
            }
            else
            {
                throw new Exception("No sendable transaction date : incorrect format");
            }

            if (!Verifier.IsEmpty(_amountString) && Verifier.IsValidAmount(_amountString))
            {
                double tempAmount = Verifier.ToAmount(_amountString);

                if(!Verifier.IsNegative(tempAmount))
                {
                    this.amount = tempAmount;
                }
                else
                {
                    throw new Exception("No sendable transaction amount : negative amount");
                }
            }
            else
            {
                throw new Exception("No sendable transaction amount : incorrect format");
            }


            if (!Verifier.IsEmpty(_zipcode) && Verifier.IsValidZipcode(_zipcode))
            {
                this.zipcode = _zipcode;
            }
            else
            {
                throw new Exception("No sendable transaction zipcode : incorrect format");
            }
        }

        public string Name { get => this.name; }

        public DateTime Date { get => this.date; }

        public double Amount { get => this.amount; }

        public string Zipcode { get => this.zipcode; }

        public override string ToString()
        {
            return "Nom : " + this.name + "\n" +
                    "Date : " + Verifier.DateToString(this.date) + "\n" +
                    "Montant : " + Verifier.AmountToString(this.amount) + " €\n" +
                    "Code Postal : " + this.zipcode + "\n";
        }
    }
}
