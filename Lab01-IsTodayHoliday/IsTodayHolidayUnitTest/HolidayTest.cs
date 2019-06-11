using System;
using IsTodayHoliday;
using NUnit.Framework;

namespace IsTodayHolidayUnitTest
{
    public class HolidayTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetThemeTest_Today_Is_Not_Dragon_Boat_Festival()
        {
            //Arrange
            var holiday = new HolidayForTest();
            holiday.SetToday( new DateTime( 2019 , 06 , 06 ) );

            //Action
            string actual = holiday.GetTheme();

            //Assert
            Assert.AreEqual( "theme.normal" , actual );
        }

        [Test]
        public void GetThemeTest_Today_Is_Dragon_Boat_Festival()
        {
            //Arrange
            var holiday = new HolidayForTest();
            holiday.SetToday( new DateTime( 2019 , 06 , 07 ) );

            //Action
            string actual = holiday.GetTheme();

            //Assert
            Assert.AreEqual( "theme.dragon-boat-festival" , actual );
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