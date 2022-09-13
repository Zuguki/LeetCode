using System;
using System.Linq;

Console.ReadKey();

public class Kata
{
    public static int[] MoveZeroes(int[] arr) => arr.OrderBy(item => item == 0).ToArray();
}