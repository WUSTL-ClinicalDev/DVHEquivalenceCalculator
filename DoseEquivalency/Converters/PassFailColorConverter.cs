using DoseEquivalency.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace DoseMetrics.Converters
{
    class PassFailColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((ToleranceEnum)value == ToleranceEnum.Pass)
            {
                return Brushes.LightGreen;
            }
            else if((ToleranceEnum)value == ToleranceEnum.Fail)
            {
                return Brushes.LightPink;
            }
            else
            {
                return Brushes.Transparent;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
