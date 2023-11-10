using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Globalization;

namespace CL_Verifier
{
    public static class Verifier
    {

        public static bool IsCorrectName(string _name)
        {
            const int MAX_LENGTH = 30;
            const string REGEX_PATTERN = @"^[A-Z][a-zï]*(\-[A-Z][a-zï]*)?$";

            Regex regex = new Regex(REGEX_PATTERN);

            return _name.Length <= MAX_LENGTH && regex.Match(_name).Success;

        }

        public static bool IsCorrectDate(string _date)
        {

            string[] formats = { "dd/MM/yyyy" };
            DateTime dateTime;

            return DateTime.TryParseExact(
                _date,
                formats,
                null,
                DateTimeStyles.None,
                out dateTime
            );

        }

        public static bool IsCorrectAmount(string _amount)
        {
            const string REGEX_PATTERN = @"^(\d)+((\.|\,)(\d){2})?$";

            Regex regex = new Regex(REGEX_PATTERN);

            return regex.Match(_amount).Success;

        }

        public static bool IsCorrectZipcode(string _zipcode)
        {
            const string REGEX_PATTERN = @"^(\d){5}$";

            Regex regex = new Regex(REGEX_PATTERN);

            return regex.Match(_zipcode).Success;
        }

    }
}
