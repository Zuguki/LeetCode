using System;
using System.Text;

// Input: PAYPALISHIRING, 3
// Example
// P   A   H   N
// A P L S I I G
// Y   I   R

// Output: PAHNAPLSIIGYIR

// Input: PAYPALISHIRING, 5
// Example
// P       H 
// A     S I
// Y   I   R
// P L     I G
// A       N

// Output: PHASIYIRPLIGAN

// Algorythm
// 0   0   0 
// 1 1 1 1 1
// 2   2   2

Console.ReadLine();

public enum GoTo
{
    Bottom = 1,
    Top = -1
}

public class Solution
{
    private string[] _strings;
    private GoTo _target = GoTo.Bottom;
    private int _rowsCounter;

    public string Convert(string str, int numRows)
    {
        if (numRows == 1)
            return str;
        
        _strings = new string[numRows];
        for (var index = 0; index < str.Length; index++)
        {
            _strings[GetNextIndex(index, numRows)] += str[index];
        }

        var sb = new StringBuilder();
        for (var index = 0; index < numRows; index++)
            sb.Append(_strings[index]);

        return sb.ToString();
    }

    private int GetNextIndex(int index, int numRows)
    {
        _target = TryChangeDirection(numRows);
        _rowsCounter += (int) _target;
        return _rowsCounter - 1;
    }

    private GoTo TryChangeDirection(int numRows)
    {
        var direction = _target;
        if (_rowsCounter is 0 or 1)
            direction = GoTo.Bottom;
        else if (_rowsCounter == numRows)
            direction = GoTo.Top;

        return direction;
    }
}
