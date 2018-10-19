using System;
using System.Globalization;

namespace Xamarin.Forms.ConvertersPack
{
    public class ItemTappedEventArgsConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is ItemTappedEventArgs itemTappedEventArgs))
                throw new ArgumentException("Erro ao converter", nameof(value));

            return itemTappedEventArgs.Item;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => null;

    }
}
