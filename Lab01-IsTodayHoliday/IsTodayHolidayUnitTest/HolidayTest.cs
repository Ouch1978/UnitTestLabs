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
            Holiday holiday = new Holiday( new DateTime( 2019 , 06 , 06 ) );

            //Action
            string actual = holiday.GetTheme();

            //Assert
            Assert.AreEqual( "theme.normal" , actual );
        }

        [Test]
        public void GetThemeTest_Today_Is_Dragon_Boat_Festival()
        {
            //Arrange
            Holiday holiday = new Holiday(new DateTime( 2019 , 06 , 07 ));

            //Action
            string actual = holiday.GetTheme();

            //Assert
            Assert.AreEqual( "theme.dragon-boat-festival" , actual );
        }

    }
}