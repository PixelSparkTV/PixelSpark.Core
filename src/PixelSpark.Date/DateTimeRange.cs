using System;

namespace PixelSpark.Date;

public class Range
{
    public DateTime PreTime { get; set; }

    public DateTime ScheduledDateTime { get; set; }

    public DateTime PostTime { get; set; }

    public DateTime LateTime { get; set; }
}