using System;
using System.Globalization;

namespace Xamarin.Forms.ConvertersPack
{
    public class DecimalConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!string.IsNullOrEmpty(value?.ToString()))
            {

                return Decimal.TryParse(value.ToString(), out decimal retorno) ? retorno : (object)0;
            }
            else
            {
                return 0;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 0;
        }
    }
}
