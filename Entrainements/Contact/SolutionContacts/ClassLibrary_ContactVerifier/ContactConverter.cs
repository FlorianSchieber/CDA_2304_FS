using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_ContactVerifier
{
    public static class ContactConverter
    {
        static public string DATE_TIME_FORMAT = "dd/MM/yyyy";

        public static string DateToString(DateTime dateTimeToConvert)
        {
            return dateTimeToConvert.ToString(DATE_TIME_FORMAT);
        }

        public static DateTime stringToDate(string stringToConvert)
        {
            DateTime dateTime;

            if (DateTime.TryParseExact(
                stringToConvert,
                new string[] {DATE_TIME_FORMAT},
                null,
                System.Globalization.DateTimeStyles.None,
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
    }
}
