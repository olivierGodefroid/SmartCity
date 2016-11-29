using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace SmartCity.Converter
{
    public class LabelToNewImage: IValueConverter
    {

        public Object Convert(object value, Type targetType, object parameter, string language)
        {
            var nameImage = (string)value;

            return "../Images/" + nameImage + ".png";

        }
        public Object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

}
