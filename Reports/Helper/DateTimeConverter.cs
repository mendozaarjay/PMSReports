using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports
{
    public static class DateTimeConverter
    {
        public static DateTime GetDateTime(DateTimePicker datePart, DateTimePicker timePart)
        {
            var date = datePart.Value.ToString("MM/dd/yyyy");
            var time = timePart.Value.ToString("hh:mm tt");
            var newDate = $"{date} {time}";
            var formattedDate = DateTime.ParseExact(newDate, "MM/dd/yyyy hh:mm tt", null);
            return formattedDate;
        }
    }
}
