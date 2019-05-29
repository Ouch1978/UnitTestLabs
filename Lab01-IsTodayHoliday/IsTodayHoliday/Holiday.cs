using System;

namespace IsTodayHoliday
{
    public class Holiday
    {
        public string GetTheme()
        {
            var today = DateTime.Today;
            return ( today.Year == 2019 && today.Month == 6 && today.Day == 7 ) ? "theme.dragon-boat-festival" : "normal";
        }

    }
}
