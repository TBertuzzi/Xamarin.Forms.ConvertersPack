using System;
using System.Globalization;

namespace Xamarin.Forms.ConvertersPack
{
    public class HexToColorConverter : IValueConverter
    {

        public static void Init()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color defaultColor = Color.FromHex("#ffffff");
            var color = value as string;
            try
            {
                return string.IsNullOrEmpty(color) ? defaultColor : Color.FromHex(color);
            }
            catch
            {
                return defaultColor;
            }
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => null;

    }
}
