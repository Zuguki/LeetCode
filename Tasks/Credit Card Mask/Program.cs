using System;
using System.Linq;

Console.ReadKey();

public class Kata
{
    public static int MaxMultiply(int divisor, int bound) => bound - bound % divisor;
}