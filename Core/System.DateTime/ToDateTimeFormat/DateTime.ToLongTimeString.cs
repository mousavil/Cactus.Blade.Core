﻿using System.Globalization;

public static partial class Extension
{
    /// <summary>
    ///     A DateTime extension method that converts this object to a long time string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToLongTimeString(this System.DateTime @this)
    {
        return @this.ToString("T", DateTimeFormatInfo.CurrentInfo);
    }

    /// <summary>
    ///     A DateTime extension method that converts this object to a long time string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="culture">The culture.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToLongTimeString(this System.DateTime @this, string culture)
    {
        return @this.ToString("T", new CultureInfo(culture));
    }

    /// <summary>
    ///     A DateTime extension method that converts this object to a long time string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="culture">The culture.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToLongTimeString(this System.DateTime @this, CultureInfo culture)
    {
        return @this.ToString("T", culture);
    }
}