using System;
using System.Globalization;

namespace Xamarin.Forms.ConvertersPack
{
    public class InvertedBooleanConverter : IValueConverter
    {

        public static void Init()
        {

        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is bool ? !(bool)value : value;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
