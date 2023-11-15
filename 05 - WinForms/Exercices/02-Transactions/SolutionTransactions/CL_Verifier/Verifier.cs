using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace CL_Verifier
{
    public static class Verifier
    {
        static string DATE_FORMAT = "dd/MM/yyyy";
        static string decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;


        public static bool IsEmpty(string _tested)
        {
            return _tested.Length == 0;
        }

        public static bool IsValidName(string _name)
        {
            
            const string REGEX_PATTERN = @"^[A-Z][a-zï]*(\-[A-Z][a-zï]*)?$";

            Regex regex = new Regex(REGEX_PATTERN);

            return regex.Match(_name).Success;

        }

        public static bool IsShortName(string _name)
        {
            const int MAX_LENGTH = 30;
            return _name.Length <= MAX_LENGTH; 
        }

        public static bool IsValidDate(string _dateString)
        {

            DateTime dateTime;

            return DateTime.TryParseExact(
                _dateString,
                new string[] { DATE_FORMAT },
                null,
                DateTimeStyles.None,
                out dateTime
            );
        }

        public static DateTime ToDate(string _dateString)
        {
            DateTime dateTime;

            if (DateTime.TryParseExact(
                _dateString,
                new string[] { DATE_FORMAT },
                null,
                DateTimeStyles.None,
                out dateTime
            ))
            {
                return dateTime;
            }
            else
            {
                throw new Exception("Invalid date string format");
            }

        }

        public static string DateToString(DateTime _date)
        {
            return _date.ToString(DATE_FORMAT);
        }

        public static bool IsFutureDate(DateTime _dateTime)
        {
            return _dateTime > DateTime.Today;
        }

        public static bool IsValidAmount(string _amountString)
        {
            const string REGEX_PATTERN = @"^(\-)?(\d)+((\.|\,)(\d){2})?$";

            Regex regex = new Regex(REGEX_PATTERN);

            return regex.Match(_amountString).Success;

        }

        public static double ToAmount(string _amountString)
        {

            double amountTemp;
            if (double.TryParse(_amountString.Replace(".", Verifier.decimalSeparator).Replace(",", Verifier.decimalSeparator), out amountTemp))
            {
                return amountTemp;
            }
            else
            {
                throw new Exception("Invalid double string format");
            }

        }

        public static string AmountToString(double _amount)
        {
            return string.Format("{0:0.00}", _amount);
        }

        public static bool IsNegative(double _double)
        {
            return _double < 0;
        }

        public static bool IsValidZipcode(string _zipcode)
        {
            const string REGEX_PATTERN = @"^(\d){5}$";

            Regex regex = new Regex(REGEX_PATTERN);

            return regex.Match(_zipcode).Success;
        }
    }
}
