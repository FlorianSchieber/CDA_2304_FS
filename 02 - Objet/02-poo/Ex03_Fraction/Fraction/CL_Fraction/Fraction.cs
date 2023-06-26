using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Fraction
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int _numerator, int _denominator)
        {
            if (_denominator != 0)
            {
                this.numerator = _numerator;
                this.denominator = _denominator;
            }
            else
            {
                throw new DivideByZeroException();
            }
        }

        public Fraction()
            : this(0, 1)
        {}

        public Fraction(int _numerator)
            : this(_numerator, 1)
        {}

        public Fraction(Fraction fractionToClone)
            : this(fractionToClone.numerator, fractionToClone.denominator)
        {}

        public static Fraction operator +(Fraction augend, Fraction addend)
        {
            return augend.Plus(addend);
        }

        public static Fraction operator -(Fraction minuend, Fraction subtrahend)
        {
            return minuend.Minus(subtrahend);
        }

        public static Fraction operator *(Fraction multiplicand, Fraction multiplier)
        {
            return multiplicand.Times(multiplier);
        }

        public static Fraction operator /(Fraction dividend, Fraction divisor)
        {
            return dividend.DivisedBy(divisor);
        }

        public void Opposite()
        {
            this.numerator = -this.numerator;
        }

        public void Inverse()
        {
            if (this.numerator != 0)
            {
                int temp = this.numerator;
                this.numerator = this.denominator;
                this.denominator = temp;
            }
            else
            {
                throw new DivideByZeroException();
            }
        }

        public double GetEvaluation()
        {
            return (double)this.numerator / this.denominator;
        }

        public bool IsGreaterThan(Fraction fractionToCompare)
        {
            return this.GetEvaluation() > fractionToCompare.GetEvaluation();
        }

        public bool IsEqualTo(Fraction fractionToCompare)
        {
            return this.GetEvaluation() == fractionToCompare.GetEvaluation();
        }

        public int GetSign()
        {
            if (this.numerator * this.denominator >= 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        private int GetPgcd()
        {
            int a = this.numerator;
            int b = this.denominator;
            int pgcd = 1;
            if (a != 0 && b != 0)
            {
                if (a < 0) a = -a;
                if (b < 0) b = -b;
                while (a != b)
                {
                    if (a < b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }
                }
                pgcd = a;
            }
            return pgcd;
        }

        private void Reduce()
        {
            int pgcd = this.GetPgcd();
            int resignedNumerator = this.GetSign() * Math.Abs(this.numerator);
            int resignedDenominator = Math.Abs(this.denominator);

            this.numerator = resignedNumerator / pgcd;
            this.denominator = resignedDenominator / pgcd;
        } 

        public Fraction Plus(Fraction addend)
        {
            int newNumerator = this.numerator * addend.denominator + this.denominator * addend.numerator;
            int newDenominator = this.denominator * addend.denominator;
            Fraction result = new Fraction(newNumerator, newDenominator);

            result.Reduce();

            return result;
        }

        public Fraction Minus(Fraction subtrahend)
        {
            Fraction subtrahendOpposite = new Fraction(subtrahend);
            
            subtrahendOpposite.Opposite();
            
            return this.Plus(subtrahendOpposite);
        }

        public Fraction Times(Fraction multiplier)
        {
            Fraction result = new Fraction
                (
                    this.numerator * multiplier.numerator,
                    this.denominator * multiplier.denominator
                );

            result.Reduce();

            return result;
        }

        public Fraction DivisedBy(Fraction divisor)
        {
            Fraction divisorInverse = new Fraction(divisor);

            divisorInverse.Inverse();

            return this.Times(divisorInverse);
        }

        public override string ToString()
        {
            if (this.denominator == 1)
            {
                return this.numerator.ToString();
            }
            else
            {
                return this.numerator + "/" + this.denominator;
            }
        }

    }
}
