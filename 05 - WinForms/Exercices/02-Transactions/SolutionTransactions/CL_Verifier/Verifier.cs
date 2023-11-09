using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Linq;

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
            const string REGEX_PATTERN = @"^(\d){2}\/(\d){2}\/(\d){4}";

            Regex regex = new Regex(REGEX_PATTERN);

            if (regex.Match(_date).Success)
            {
                string[] formats = { "dd/MM/yyyy", "HHmmss" };
                DateTime dateTime;

                return DateTime.TryParseExact(_date, formats, null,
                               System.Globalization.DateTimeStyles.AllowWhiteSpaces |
                               System.Globalization.DateTimeStyles.AdjustToUniversal,
                               out dateTime);

            }

            return false;

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
