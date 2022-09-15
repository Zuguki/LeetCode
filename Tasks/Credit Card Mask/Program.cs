using System;
using System.Linq;

Console.ReadKey();

public class Kata
{
    public static int[] ArrayDiff(int[] a, int[] b) => a.Where(item => b.All(bItem => bItem != item)).ToArray();
}