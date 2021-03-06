﻿using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts the @this to an int 64.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a long.</returns>
    public static long ToInt64(this object @this)
    {
        return Convert.ToInt64(@this);
    }
}