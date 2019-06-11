using System;

namespace IsTodayHoliday
{
    public class Holiday
    {
        protected virtual DateTime GetToday()
        {
            return DateTime.Today;
        }

        public string GetTheme()
        {
            var today = GetToday();
            return ( today.Year == 2019 && today.Month == 6 && today.Day == 7 ) ? "theme.dragon-boat-festival" : "theme.normal";
        }
    }
}
