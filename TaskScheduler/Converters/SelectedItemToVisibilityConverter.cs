using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace TaskScheduler.Converters
{
    internal class SelectedItemToVisibilityConverter : IValueConverter
    {
        public Visibility TrueValue { get; }
        public Visibility FalseValue { get; }

        public SelectedItemToVisibilityConverter()
        {
            TrueValue = Visibility.Visible;
            FalseValue = Visibility.Collapsed;
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null ? TrueValue : FalseValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
