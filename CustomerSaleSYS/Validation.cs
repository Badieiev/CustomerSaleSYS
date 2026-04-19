using System;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace CustomerSaleSYS
{
    public static class Validation
    {
        // https://stackoverflow.com/questions/5342375/regex-email-validation
        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool IsAlphabetical(string s)
        {
            if (Regex.IsMatch(s, @"^[a-zA-Z]+$"))
            {
                return true;
            }
            else {
                return false; }
        }

        //https://learn.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.ismatch?view=net-10.0
        public static bool IsValidPhoneNumber(string phone)
        {
            if (Regex.IsMatch(phone, @"^\+353|0\d{9}$"))
            {
                return true;
            }else { return false; }
        }

        public static bool IsValidDecimal(string s)
        {
            decimal d;
            if (decimal.TryParse(s, out d))
            {
                if (d >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool IsPositiveInteger(string s)
        {
            int q;
            if (int.TryParse(s, out q))
            {
                if (q > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool IsNonNegativeNumber(string s)
        {
            int q;
            if (int.TryParse(s, out q))
            {
                if (q >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
