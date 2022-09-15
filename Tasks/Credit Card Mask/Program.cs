using System;
using System.Numerics;

Console.ReadKey();

public class Kata
{
    public static string? Add(string a, string b) => (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
}