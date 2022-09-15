using System;
using System.Collections.Generic;
using System.Text;

Console.ReadKey();

public class RomanNumerals
{
    private static readonly Dictionary<char, int> _romanValues = new()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public static string ToRoman(int n)
    {
        var sb = new StringBuilder();
        var value = GetLetters(n, 'M');
        sb.Append(value.Item1);

        value = GetLetters(value.Item2, 'D', 'M', true);
        sb.Append(value.Item1);

        value = GetLetters(value.Item2, 'C', 'D', true);
        sb.Append(value.Item1);

        value = GetLetters(value.Item2, 'L', 'C', true);
        sb.Append(value.Item1);

        value = GetLetters(value.Item2, 'X', 'L', true);
        sb.Append(value.Item1);

        value = GetLetters(value.Item2, 'V');
        sb.Append(value.Item1);

        value = GetLetters(value.Item2, 'I', 'V', true);
        sb.Append(value.Item1);
        
        return sb.ToString();
    }

    public static int FromRoman(string romanNumeral)
    {
        var number = 0;
        for (var index = 0; index < romanNumeral.Length; index++)
        {
            if (index < romanNumeral.Length - 1
                && _romanValues[romanNumeral[index]] >= _romanValues[romanNumeral[index + 1]]
                || index == romanNumeral.Length - 1)
                number += _romanValues[romanNumeral[index]];
            else
            {
                number += _romanValues[romanNumeral[index + 1]] - _romanValues[romanNumeral[index]];
                index++;
            }
        }

        return number;
    }

    private static (string, int) GetLetters(int value, char currentChar, char previewChar = default, bool needs4Check = false)
    {
        var str = string.Empty;
        var currentValue = _romanValues[currentChar];
        var counter = value / currentValue;
        
        if (counter == 0)
            return (str, value);
        
        if (previewChar == default || !needs4Check)
        {
            str = new string(currentChar, counter);
            return (str, value % currentValue);
        }

        if (counter == 4)
            str = currentChar + previewChar.ToString();
        else
            str = new string(currentChar, counter);
        return (str, value % currentValue);
    }
}