using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary_ContactVerifier
{
    static class ContactVerifier
    {
        static string FIRST_NAME_REGEX = @"^[A-Z][a-z]*(\-[A-Z][a-z])?$";
        static string LAST_NAME_REGEX = @"^[A-Z][a-z]*$";
        static string ZIPCODE_REGEX = @"^[0-9]$";
        static string PHONE_NUMBER_REGEX = @"^([0-9]*(\.|\s|\.\s)?)*$";
        static string EMAIL_REGEX = @"^[a-z0-9\.]*\@[a-z]*\.[a-z]{2,4}$";

        static int FIRST_NAME_MAX_LENGTH = 30;
        static int LAST_NAME_MAX_LENGTH = 30;
        static int ZIP_CODE_LENGTH = 5;

        public static bool IsNotVoid(string stringToVerify)
        {
            return stringToVerify.Length > 0;
        }

        #region FirstName
        public static bool IsFormattedFirstName(string firstName)
        {
            Regex regex = new Regex(FIRST_NAME_REGEX);
            return regex.Match(firstName).Success;
        }

        public static bool IsShortFirstName(string firstName)
        {
            return firstName.Length < FIRST_NAME_MAX_LENGTH;
        }
        public static bool IsValidFirstName(string firstName)
        {
            return IsNotVoid(firstName) && IsFormattedFirstName(firstName) && IsShortFirstName(firstName);
        }
        #endregion FirstName

        #region LastName
        public static bool IsFormattedLastName(string lastName)
        {
            Regex regex = new Regex(LAST_NAME_REGEX);
            return regex.Match(lastName).Success;
        }

        public static bool IsShortLastName(string lastName)
        {
            return lastName.Length < LAST_NAME_MAX_LENGTH;
        }
        public static bool IsValidLastName(string lastName)
        {
            return IsNotVoid(lastName) && IsFormattedLastName(lastName) && IsShortLastName(lastName);
        }
        #endregion LastName

        #region BirthDate
        public static bool IsFormattedBirthDate(string birthDateString)
        {
            DateTime dateTime;

            return (DateTime.TryParseExact(
                birthDateString,
                new string[] { ContactConverter.DATE_TIME_FORMAT },
                null,
                System.Globalization.DateTimeStyles.None,
                out dateTime
            ));
        }

        public static bool IsMajorBirthDate(DateTime dateTime)
        {
            return dateTime.AddYears(18) <= DateTime.Today;
        }
        #endregion BirthDate

        #region ZipCode

        public static bool IsFormattedZipCode(string zipCode)
        {
            Regex regex = new Regex(ZIPCODE_REGEX);
            return regex.Match(zipCode).Success;
        }

        public static bool IsGoodLengthZipCode(string zipCode)
        {
            return zipCode.Length == ZIP_CODE_LENGTH;
        }

        public static bool IsValidZipCode(string zipCode)
        {
            return IsFormattedZipCode(zipCode) && IsGoodLengthZipCode(zipCode);
        }
        #endregion ZipCode

        #region PhoneNumber
        public static bool IsFormattedPhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex(PHONE_NUMBER_REGEX);
            return regex.Match(phoneNumber).Success;
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return IsNotVoid(phoneNumber) && IsFormattedPhoneNumber(phoneNumber);
        }
        #endregion PhoneNumber

        #region Email

        public static bool IsFormattedEmail(string email)
        {
            Regex regex = new Regex(EMAIL_REGEX);
            return regex.Match(email).Success;
        }

        public static bool IsValidEmail(string email)
        {
            return IsNotVoid(email) && IsFormattedEmail(email);
        }
        #endregion Email
    }
}
