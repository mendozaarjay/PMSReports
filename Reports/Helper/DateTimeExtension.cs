using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports
{
    public static class DateTimeExtension
    {
        public static DateTime Maximum(this DateTime date)
        {
            var newDate = date.Minimun();
            var _returnThis = newDate.AddHours(23).AddMinutes(59).AddSeconds(59);
            return _returnThis;
        }
        public static DateTime Minimun(this DateTime date)
        {
            var newDate = date.ToString("MM/dd/yyyy");
            return DateTime.ParseExact(newDate, "MM/dd/yyyy", null);
        }
    }
}
