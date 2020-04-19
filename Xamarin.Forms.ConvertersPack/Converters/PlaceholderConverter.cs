using System;
using System.Globalization;

namespace Xamarin.Forms.ConvertersPack.Converters
{
    public class PlaceholderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return parameter;
            if (string.IsNullOrWhiteSpace(value.ToString())) return parameter;
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}