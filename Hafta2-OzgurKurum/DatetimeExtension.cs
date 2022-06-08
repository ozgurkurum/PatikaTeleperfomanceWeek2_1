using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_OzgurKurum
{
    public static class DatetimeExtension
    {
        public static string DifferenceDate(this DateTime date)
        {
            DateTime now = DateTime.Now;
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, 0);

            if (date > now)
            {
                ts = date - now;
            }

            else
            {
                ts = now - date;
            }

            return $"Girdiğiniz günle bugün arasında {ts.Days} gün {ts.Hours} saat {ts.Minutes} dakika fark var";
        }
    }
}
