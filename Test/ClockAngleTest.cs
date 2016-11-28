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
      float expectedResult = -17;

      float result = newClock.hourMinusMinutes();

      Assert.Equal(result, expectedResult);
    }
    [Fact]
    public void ClockAngleFind_minutesToDegrees_true()
    {
      Clock newClock = new Clock(1, 24);
      float expectedResult = 102;

      float result = newClock.minutesToDegrees();

      Assert.Equal(result, expectedResult);
    }
    [Fact]
    public void ClockAngleFind_testOver180_true()
    {
      Clock newClock = new Clock(11, 15);
      float expectedResult = 112.5F;

      float result = newClock.testFor180();

      Assert.Equal(result, expectedResult);
    }
  }
}
