using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

Console.WriteLine(DigPow.digPow(89, 1));

public class DigPow 
{
    public static long digPow(int n, int p)
    {
        var strFromNumber = n.ToString();
        var multiplyValue = p;
        var resultValue = strFromNumber.Select(sym => int.Parse(sym.ToString()))
            .Select(parseValue => (int) Math.Pow(parseValue, multiplyValue++)).Sum();

        if (resultValue % n == 0)
            return resultValue / n;
        return -1;
    }
}
