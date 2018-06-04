using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace AcNmb.Core.Utils.Converters
{
    public class ThreadNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if(null == value)
            {
                return null;
            }

            return "No." + value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
