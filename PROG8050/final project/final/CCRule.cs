using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Controls;

namespace final
{
    class CCRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            if (!CheckCard(value.ToString()) || value.ToString() == "")
            {
                return new ValidationResult(false, "Incorrect credit card number");
            }
            return ValidationResult.ValidResult;
        }
        public static bool CheckCard(string card)
        {
            if (card.Length != 16)
                return false;
            char[] c = card.ToCharArray();
            for (int j = 0; j < 16; j++)
            {
                if (Char.IsLetter(c[j]) || c[j] == ' ')
                    return false;
            }
            return true;
        }
    }
}
