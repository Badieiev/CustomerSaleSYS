using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static bool IsValidPhone(string phone)
        {
            if (phone.All(char.IsDigit) && phone.Length ==10)
            {
                return true;
            }
            else { return false; }
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

        public static bool IsValidQuantity(string s)
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
    }
}
