using System;

namespace IsTodayHoliday
{
    public class Holiday
    {
        private DateTime _dateTime;

        public Holiday( DateTime dateTime )
        {
            this._dateTime = dateTime;
        }

        public Holiday()
        {
            this._dateTime = DateTime.Today;
        }

        public string GetTheme()
        {
            var today = _dateTime;
            return ( today.Year == 2019 && today.Month == 6 && today.Day == 7 ) ? "theme.dragon-boat-festival" : "theme.normal";
        }

    }
}
