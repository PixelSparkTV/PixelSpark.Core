using System;

namespace Reminder.Date;

public interface IDateTimeService
{
    DateTime GetNow();
    DateTime GetNowUtc();
    DateTimeOffset GetOffset();
    DateTimeOffset GetOffsetUtc();
}