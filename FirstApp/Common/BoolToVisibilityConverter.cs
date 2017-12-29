using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace FirstApp.Common
{
    public class BoolToVisibilityConverter : IValueConverter
    {
            public BoolToVisibilityConverter()
            {
            }
            public object Convert(object value, Type targetType, object parameter, string language) => (bool)value == (false) ? Visibility.Visible : Visibility.Collapsed;
            public object ConvertBack(object value, Type targetType, object parameter, string language) { throw new NotImplementedException(); }
        }
}



