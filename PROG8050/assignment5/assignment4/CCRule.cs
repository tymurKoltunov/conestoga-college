using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using assignment3;

namespace assignment4
{
    class CCRule : ValidationRule
    {
        
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            
            if (!Program.CheckCard(value.ToString()) || value.ToString() == "")
            {
                return new ValidationResult(false, "Incorrect credit card number");
            }
            return ValidationResult.ValidResult;
        }
    }
}
