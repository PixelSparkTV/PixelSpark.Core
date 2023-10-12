using System;

namespace PixelSpark.Date;

public interface IDateTimeRangeService
{
        bool HasPassed(Range range);

        bool InRange(Range range);

        bool IsEarly(Range range);

        bool IsLate(Range range);

        bool IsOnTime(Range range);
}