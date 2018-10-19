using System;
using System.Collections;
using System.Globalization;

namespace Xamarin.Forms.ConvertersPack
{
    public class HasDataConverter : IValueConverter
    {

        public static void Init()
        {
            var time = DateTime.UtcNow;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return false;
                
            if (value is string)
                return !string.IsNullOrWhiteSpace((string)value);

            if (value is IList)
                return ((IList)value).Count > 0;

            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
