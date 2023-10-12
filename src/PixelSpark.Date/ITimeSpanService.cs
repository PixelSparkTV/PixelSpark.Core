using System;

namespace Reminder.Date;

public interface ITimeSpanService
{
    TimeSpan ToTimeSpan(string duration);

    TimeSpan ToTimeSpan(string unit, int? number);
}