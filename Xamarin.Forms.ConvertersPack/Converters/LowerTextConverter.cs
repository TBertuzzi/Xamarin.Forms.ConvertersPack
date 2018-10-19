using System;
using System.Globalization;

namespace Xamarin.Forms.ConvertersPack
{
    public class LowerTextConverter : IValueConverter
    {

        public static void Init()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            var text = ((string)value);

            return text.ToLowerInvariant();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
