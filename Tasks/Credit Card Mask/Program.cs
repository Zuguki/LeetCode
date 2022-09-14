using System;
using System.Collections.Generic;
using System.Linq;

Console.ReadKey();

class Kata
{
    public static bool IsValidIp(string ipAddres)
    {
        var values = ipAddres.Split('.');
        if (values.Length != 4)
            return false;

        foreach (var value in values)
        {
            var parseValue = int.TryParse(value, out var intValue);
            if (value.Length > 1 && value[0] == '0' || !parseValue || intValue is < 0 or > 255 || value.Contains(' '))
                return false;
        }

        return true;
    }
}