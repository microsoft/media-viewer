using System;
using System.Net;
using System.Windows;
using System.Windows.Data;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace MediaViewer.Converters
{
    /// <summary>
    /// Converter for song duration value
    /// </summary>
    public class DurationValueConverter : IValueConverter
    {
        /// <summary>
        /// Converts TimeSpan representation of duration to string representation
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null) 
                return null;

            TimeSpan d = (TimeSpan)value;
            int s = d.Seconds;
            String seconds = s.ToString();

            if (s < 10)
            {
                seconds = "0" + seconds;
            }

            string duration = d.Minutes + ":" + seconds;

            return duration;
        }

        /// <summary>
        /// Converts back string duration representation to TimeSpan representation
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string strValue = value as string;
            TimeSpan resultDateTime;
            if (TimeSpan.TryParse(strValue, out resultDateTime))
            {
                return resultDateTime;
            }
            return DependencyProperty.UnsetValue;
        }
    }
}
