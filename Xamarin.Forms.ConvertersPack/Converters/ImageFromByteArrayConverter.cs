using System;
using System.IO;

namespace Xamarin.Forms.ConvertersPack
{
    public class ImageFromByteArrayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                byte[] bytes = (byte[])value;
                Stream stream = new MemoryStream(bytes);
                return ImageSource.FromStream(() => stream);
            }
            else
            {
                return null;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
