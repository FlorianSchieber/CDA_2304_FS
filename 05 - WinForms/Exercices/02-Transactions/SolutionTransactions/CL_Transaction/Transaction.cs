using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Transaction
{
    internal class Transaction
    {
        private string name;
        private DateTime date;
        private double amount;
        private string zipcode;

        public Transaction(string _name, DateTime _date, double _amount, string _zipcode)
        {
            this.name = _name;
            this.date = _date;
            this.amount = _amount;
            this.zipcode = _zipcode;
        }

        public void Modify(string _name, DateTime _date, double _amount, string _zipcode)
        {
            this.name = _name;
            this.date = _date;
            this.amount = _amount;
            this.zipcode = _zipcode;
        }
    }
}
