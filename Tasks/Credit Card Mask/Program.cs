using System;
using System.Linq;
using System.Text;

Console.ReadKey();

public class Kata
{
    public static string? Add(string a, string b)
    {
        var sb = new StringBuilder();
        var science = 0;
        var counter = 0;
        while (counter++ < Math.Max(a.Length, b.Length))
        {
            var aInt = 0;
            var bInt = 0;
            
            if (a.Length < counter)
                aInt = 0 + science > 0 ? science-- : 0;
            else
                aInt = int.Parse(a[^counter].ToString()) + (science > 0 ? science-- : 0);

            if (b.Length >= counter)
                bInt = int.Parse(b[^counter].ToString());
            
            if (aInt + bInt >= 10)
            {
                sb.Append((aInt + bInt) % 10);
                science++;
            }
            else
                sb.Append(aInt + bInt);
        }

        if (science > 0)
            sb.Append(science);

        var result = new StringBuilder();
        foreach (var sym in sb.ToString().Reverse())
            result.Append(sym);

        return result.ToString();
    } 
}