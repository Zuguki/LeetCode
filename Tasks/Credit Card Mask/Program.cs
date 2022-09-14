using System;
using System.Linq;

Console.ReadKey();

public class Kata
{
    public static int MaxMultiply(int divisor, int bound)
    {
        for (var value = bound; value > 0; value--)
        {
            if (value % divisor == 0)
                return value;
        }

        return -1;
    }
}