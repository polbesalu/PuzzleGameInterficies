using System;
using System.Globalization;
using System.Windows.Data;

namespace Puzle
{
    [ValueConversion(typeof(double), typeof(int))]
    internal class DoubleRound : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double number = (double)value;
            return (int)number;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
