using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine(Kata.Solution(10));
Console.ReadKey();

public static class Kata
{
    public static int Solution(int value)
    {
        if (value < 0)
            return -1;

        var result = 0;
        for (var item = 0; item < value; item++)
        {
            if (item % 3 == 0 && item != 0)
            {
                result += item;
                continue;
            }

            if (item % 5 == 0 && item != 0)
                result += item;
        }

        return result;
    }
}
