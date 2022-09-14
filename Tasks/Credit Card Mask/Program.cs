using System;
using System.Text;

Console.ReadKey();

public class Kata
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        var sb = new StringBuilder();
        for (var index = 0; index < numbers.Length; index++)
        {
            if (index == 0)
                sb.Append('(');
            if (index == 3)
                sb.Append(") ");
            if (index == 6)
                sb.Append('-');

            sb.Append(numbers[index]);
        }

        return sb.ToString();
    }
}