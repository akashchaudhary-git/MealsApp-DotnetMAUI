using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Converters;

namespace Meals_App.Converters
{
    class DayTimeToMealDayConverter : BaseConverter<object, string>
    {
        public override string DefaultConvertReturnValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override object DefaultConvertBackReturnValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override object ConvertBackTo(string value, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override string ConvertFrom(object value, CultureInfo culture)
        {
            DateTime dateTime = (DateTime)value;
            return (dateTime.Date - DateTime.Today).TotalDays switch
            {
                0 => "Today",
                1 => "Tommorow",
                _ => $"{dateTime.DayOfWeek}, {dateTime.Day}.{dateTime.Month}",
            };
        }
    }
}
