﻿using System;

public static partial class Extension
{
    /// <summary>
    ///     Subtracts an offset from the value of an unsigned pointer.
    /// </summary>
    /// <param name="pointer">The unsigned pointer to subtract the offset from.</param>
    /// <param name="offset">The offset to subtract.</param>
    /// <returns>A new unsigned pointer that reflects the subtraction of  from .</returns>
    public static UIntPtr Subtract(this UIntPtr pointer, int offset)
    {
        return UIntPtr.Subtract(pointer, offset);
    }
}