

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
      float hourMove = _minute/12;
      return hourMove;
    }
    public float hourToMinute()
    {
      float hToM = _hour*5;
      return hToM;
    }
    public float hourMinusMinutes()
    {
      float hours = minuteToHourMovement() + hourToMinute();
      float result = hours - _minute;
      return result;
    }
  }
}
