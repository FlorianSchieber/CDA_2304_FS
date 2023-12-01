using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CL_Repayment.Repayment;
using System.Xml.Linq;

namespace CL_Repayment
{
    public enum Compound : int // month by repayment
    {
        Monthly = 1,
        Bimonthly = 2,
        Quarterly = 3,
        SemiAnnually = 6,
        Annually = 12
    }

    public class Repayment
    {
        private string name;
        private int loanBalance;
        private int repaymentNumber;
        private Compound compound;
        private double annualInterestRate;

        public Repayment(string _name, int _loanBalance, int _repaymentNumber, Compound _compound, double _interestRate)
        {
            this.name = _name;
            this.loanBalance = _loanBalance;
            this.repaymentNumber = _repaymentNumber;
            this.compound = _compound;
            this.annualInterestRate = _interestRate;

            this.VerifyRepayment();
        }

        public Repayment()
        {
            this.name = "";
            this.loanBalance = 0;
            this.repaymentNumber = 1;
            this.compound = Compound.Monthly;
            this.annualInterestRate = 0.07;

            this.VerifyRepayment();
        }

        public Repayment(Repayment _repayment)
        {
            this.name = _repayment.Name;
            this.loanBalance = _repayment.LoanBalance;
            this.repaymentNumber = _repayment.RepaymentNumber;
            this.compound = _repayment.Compound;
            this.annualInterestRate = _repayment.AnnualInterestRate;
        }

        public string Name { get { return this.name; } }
        public int LoanBalance { get { return this.loanBalance; } }
        public int RepaymentNumber { get { return this.repaymentNumber; } }
        public Compound Compound { get { return this.compound; } }
        public double AnnualInterestRate { get { return this.annualInterestRate; } }

        public void VerifyRepayment()
        {
            if (!this.RepaymentNumberIsValid())
            {
                throw new Exception("Zero repayment number");
            }

            if (!this.InterestRateIsValid())
            {
                throw new Exception("Zero interest rate");
            }
        }

        public bool RepaymentNumberIsValid()
        {
            return this.repaymentNumber != 0;
        }

        public bool InterestRateIsValid()
        {
            return this.annualInterestRate != 0;
        }

        public int RepaymentTimeInMonth()
        {
            return this.repaymentNumber * (int)this.compound;
        }

        public double RepaymentValue()
        {
            int k = this.loanBalance;
            int p = (int)this.compound;
            double t = this.annualInterestRate / (12 / p);
            int n = this.RepaymentNumber;

            return (k * t) / (1 - Math.Pow(1 + t, -n));
        }
    }
}
