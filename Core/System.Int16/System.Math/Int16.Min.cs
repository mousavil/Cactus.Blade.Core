﻿using System;

public static partial class Extension
{
    /// <summary>
    ///     Returns the smaller of two 16-bit signed integers.
    /// </summary>
    /// <param name="this">The first of two 16-bit signed integers to compare.</param>
    /// <param name="value">The second of two 16-bit signed integers to compare.</param>
    /// <returns>Parameter  or , whichever is smaller.</returns>
    public static short Min(this short @this, short value)
    {
        return Math.Min(@this, value);
    }
}