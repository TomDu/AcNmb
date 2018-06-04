using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace AcNmb.Core.Utils.Converters
{
    public class ContentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (null == value)
            {
                return null;
            }

            string str = value.ToString();
            int idx = str.IndexOf("<br />");
            while (idx != -1)
            {
                str = str.Remove(idx, 6);
                idx = str.IndexOf("<br />", idx);
            }

            return str;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
