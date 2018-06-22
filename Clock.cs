using System;

public struct Clock
{
    public Clock(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;

        toMinutes(minutes);
        toHour(Hours);
    }

    public int Hours { get; set; }

    public int Minutes { get; set; }

    public Clock Add(int minutesToAdd)
    {
        Minutes += minutesToAdd;

        toMinutes(Minutes);
        toHour(Hours);

        return this;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        Minutes -= minutesToSubtract;

        toMinutes(Minutes);
        toHour(Hours);

        return this;
    }

    public override string ToString() => $"{Hours:00}:{Minutes:00}";

    public void toHour(int hours)
    {
        while (hours >= 24)
        {
            hours = hours - 24;
        }

        while (hours < 0)
        {
            hours = 24 - (hours*-1);
        }

        Hours = hours; 
    }

    public void toMinutes(int minutes)
    {
        while (minutes >= 60)
        {
            Hours++;
            minutes = minutes - 60;
        }

        while (minutes < 0)
        {
            Hours--;
            minutes = 60 - (minutes * -1);
        }

        Minutes = minutes;
    }
}