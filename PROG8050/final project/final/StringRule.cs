using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Controls;

namespace final
{
    class StringRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            if (value.ToString() == "")
            {
                return new ValidationResult(false, "Field cannot be empty");
            }
            return ValidationResult.ValidResult;
        }
    }
}
