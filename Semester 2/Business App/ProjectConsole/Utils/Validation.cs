using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectConsole.Util
{
    // this class is used to validate user input
    internal class Validation
    {
        public static bool IsWorthValid(int amount)
        {
            if (amount == 0 || amount < 0)
                return false;
            return true;
        }
        public static bool IsValid(string type, string check, bool flag = true)
        {
            if (string.IsNullOrWhiteSpace(check))
            {
                UtilUi.Error($"{type} can't be empty", false);
                return false;
            }
            else if (check.Length < 3)
            {
                UtilUi.Error($"{type} should at least contain 3 characters", false);
                return false;
            }
            else if (check.Length > 20)
            {
                UtilUi.Error($"{type} should be less than 20 characters", false);
                return false;
            }
            else if (check.Contains(" "))
            {
                UtilUi.Error($"{type} can't have a space", false);
                return false;
            }
            if (flag)    // check for username and password
            {
                if (check.Any(char.IsDigit))
                {
                    UtilUi.Error($"{type} can't have a number", false);
                    return false;
                }

                else if (ContainsSymbol(check))
                {
                    UtilUi.Error($"{type} can't have a special character", false);
                    return false;
                }
            }
            else
            {
                if (check.Contains(","))
                {
                    UtilUi.Error($"{type} can't have comma(,)", false);
                    return false;
                }
            }
            return true;
        }
        private static bool ContainsSymbol(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetterOrDigit(c) && c != ' ')
                    return true;
            }
            return false;
        }
        public static bool IsValidNumber(ref int num)
        {
            try
            {
                num = int.Parse(Console.ReadLine());
                return true;
            }
            catch (Exception)
            {
                UtilUi.Error("Incorrect format...", false);
                return false;
            }
        }
    }
}