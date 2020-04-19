using System;
using System.Globalization;

namespace Xamarin.Forms.ConvertersPack.Converters
{
    public class RoundedNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double valueAsDouble && valueAsDouble >= 1)
            {
                return decimal.Round((decimal)valueAsDouble, 2, MidpointRounding.AwayFromZero);
            }

            if (value is decimal valueAsDecimal && valueAsDecimal >= 1)
            {
                return decimal.Round(valueAsDecimal, 2, MidpointRounding.AwayFromZero);
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double valueAsDouble && valueAsDouble > 0)
            {
                return decimal.Round((decimal)valueAsDouble, 2, MidpointRounding.AwayFromZero);
            }

            if (value is decimal valueAsDecimal && valueAsDecimal > 0)
            {
                return decimal.Round(valueAsDecimal, 2, MidpointRounding.AwayFromZero);
            }

            return value;
        }
    }
}