using System;

namespace ClockAngle.Objects
{
  public class Clock
  {
    private int _hour;
    private int _minute;

    public Clock(int hour, int minute)
    {
      _hour = hour;
      _minute = minute;
    }
    public float minuteToHourMovement()
    {
      float hourMove = _minute/12F;
      return hourMove;
    }
    public float hourToMinute()
    {
      float hToM = _hour*5F;
      return hToM;
    }
    public float hourMinusMinutes()
    {
      float hours = minuteToHourMovement() + hourToMinute();
      float result = hours - _minute;
      return result;
    }
    public float minutesToDegrees()
    {
      float result = Math.Abs(hourMinusMinutes()) * 6F;
      return result;
    }
    public float testFor180()
    {
      float result;
      if (minutesToDegrees() > 180)
      {
        result = 360F - minutesToDegrees();
      }
      else
      {
        result = minutesToDegrees();
      }
      return result;
    }
  }
}
