﻿public static partial class Extension
{
    /// <summary>
    ///     A DateTimeOffset extension method that last day of week.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DateTimeOffset.</returns>
    public static System.DateTimeOffset LastDayOfWeek(this System.DateTimeOffset @this)
    {
        return new System.DateTimeOffset(@this.Year, @this.Month, @this.Day, 0, 0, 0, @this.Offset).AddDays(6 - (int)@this.DayOfWeek);
    }
}