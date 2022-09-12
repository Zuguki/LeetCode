using System;
using System.Collections.Generic;
using System.Linq;

var str = "abcde";
Console.WriteLine(Kata.DuplicateCount(str));

public class Kata
{
    public static int DuplicateCount(string str)
    {
        str = str.ToLower();
        var dict = new Dictionary<char, int>();
        
        foreach (var symbol in str)
        {
            if (!dict.ContainsKey(symbol))
                dict.Add(symbol, 0);
            dict[symbol]++;
        }

        return dict.Count(item => item.Value > 1);
    }
}
