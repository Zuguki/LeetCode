using System;
using System.Collections.Generic;
using System.Linq;

Console.ReadKey();

public static class Kata
{
    public static long RowSumOddNumbers(long n)
    {
        var arr = new int[n];
        var value = -1;
        for (var index = 0; index < n; index++)
        {
            for (var _ = 0; _ < index + 1; _++)
            {
                value += 2;
                arr[index] += value;
            }
        }

        return arr[n - 1];
    }
}