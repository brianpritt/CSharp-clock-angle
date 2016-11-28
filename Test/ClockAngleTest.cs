using Xunit;
using System.Collections.Generic;
using System;
using ClockAngle.Objects;

namespace ClockAngle
{
  public class AngleFindTest
  {
    [Fact]
    public void ClockAngleFind_hourMoveValue_true()
    {
      //Arrange
      float expectedResult = 2;
      Clock newClock = new Clock(1, 24);
      //Act
      float result = newClock.minuteToHourMovement();
      //Assert
      Assert.Equal(result, expectedResult);
    }
    [Fact]
    public void ClockAngleFind_hourToMinute_true()
    {
      //Arrange
      float expectedResult = 5;
      Clock newClock = new Clock(1, 24);
      //Act
      float result = newClock.hourToMinute();
      //Assert
      Assert.Equal(result, expectedResult);
    }
    [Fact]
    public void ClockAngleFind_hourMinusMinutes_true()
    {
      Clock newClock = new Clock(1, 24);
      float hours = newClock.minuteToHourMovement() + newClock.hourToMinute();
      float expectedResult = 7;

      float result = newClock.hourMinusMinutes();
    }
  }
}
