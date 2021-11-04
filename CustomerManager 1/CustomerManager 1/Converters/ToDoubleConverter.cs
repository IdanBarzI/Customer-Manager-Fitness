using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CustomerManager_1.Converters
{
    class ToDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            string number = value.ToString();
            string paramaterStr = parameter.ToString();
            if (paramaterStr == "Height")
            {
                switch (number.Length)
                {
                    case 2:
                        if (number[1] != '.')
                        {
                            string numberDouble = number.Insert(1, ".");
                            return numberDouble;
                        }
                        return number;
                    default:
                        return number;
                }
            }
            switch (number.Length)
            {
                case 3:
                    if (number[2] != '.')
                    {
                        string numberDouble = number.Insert(2, ".");
                        return numberDouble;
                    }
                    return number;
                default:
                    return number;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

    }
}
