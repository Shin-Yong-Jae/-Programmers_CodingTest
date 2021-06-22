using System;
using System.Collections.Generic;
public class Solution {
    public static char[] CircularShiftLeft(char[] arr, int shifts)
    {
        var dest = new char[arr.Length];
        Array.Copy(arr, shifts, dest, 0, arr.Length - shifts);
        Array.Copy(arr, 0, dest, arr.Length - shifts, shifts);
        return dest;
    }
    