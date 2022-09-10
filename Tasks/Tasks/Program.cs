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


Console.ReadLine();

public class Solution
{
    private string[] _strings;
    private readonly Stack<int> _stack = new();
    private bool _stackClear = true;
    private int _stackCounter;

    public string Convert(string str, int numRows)
    {
        if (numRows == 1)
            return str;
        
        _strings = new string[numRows];
        for (var index = 0; index < str.Length; index++)
            _strings[GetNextIndex(index, numRows)] += str[index];

        var sb = new StringBuilder();
        for (var index = 0; index < numRows; index++)
            sb.Append(_strings[index]);

        return sb.ToString();
    }

    private int GetNextIndex(int index, int numRows)
    {
        if (_stack.Count == 0)
            _stackClear = true;
        if (_stackCounter == numRows && _stack.Count != 0)
        {
            _stackClear = false;
            _stackCounter = 0;
        }
        
        if (!_stackClear)
            return _stack.Pop();

        if (_stackClear && _stackCounter != 0 && _stackCounter != numRows - 1)
            _stack.Push(_stackCounter);
        
        return _stackCounter++;
    }
}
