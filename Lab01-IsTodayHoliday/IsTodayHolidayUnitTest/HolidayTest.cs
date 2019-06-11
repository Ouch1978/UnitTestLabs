using System;
using IsTodayHoliday;
using NUnit.Framework;

namespace IsTodayHolidayUnitTest
{
    public class HolidayTest
    {
        private HolidayForTest _holidayForTest;

        [SetUp]
        public void Setup()
        {
            _holidayForTest = new HolidayForTest();
        }

        [Test]
        public void GetThemeTest_Today_Is_Not_Dragon_Boat_Festival()
        {
            GivenToday( 2019 , 06 , 06 );

            ShouldReturnTheme( "theme.normal" );
        }

        [Test]
        public void GetThemeTest_Today_Is_Dragon_Boat_Festival()
        {
            GivenToday( 2019 , 06 , 07 );

            ShouldReturnTheme( "theme.dragon-boat-festival" );
        }

        private void ShouldReturnTheme( string theme )
        {
            Assert.AreEqual( theme , _holidayForTest.GetTheme() );
        }

        private void GivenToday( int year , int month , int day )
        {
            _holidayForTest.SetToday( new DateTime( year , month , day ) );
        }
    }

    public class HolidayForTest : Holiday
    {
        private DateTime _today;

        protected override DateTime GetToday()
        {
            return _today;
        }

        public void SetToday( DateTime today )
        {
            _today = today;
        }
    }
}