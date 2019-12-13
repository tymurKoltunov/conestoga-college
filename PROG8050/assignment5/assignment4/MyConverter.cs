using assignment3;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
namespace assignment4
{
    [ValueConversion(typeof(int), typeof(Brush))]
    public class MyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Building) 
            {
                if (((Building)value).Size > 40000)
                {
                    return Brushes.Red;
                }
                else
                {
                    return Brushes.White;
                }                    
            }
            else
            {
                return Brushes.White;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
