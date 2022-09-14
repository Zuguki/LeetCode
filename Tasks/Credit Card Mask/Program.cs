using System;
using System.Text;

Console.ReadKey();

public class Kata
{
    public static string SpinWords(string sentence)
    {
        var words = sentence.Split(' ');
        var spaces = words.Length - 1;
        var sb = new StringBuilder();

        foreach (var word in words)
        {
            sb.Append(word.Length < 5 ? word : Palindrome(word));

            if (spaces-- > 0)
                sb.Append(' ');
        }

        return sb.ToString();
    }

    private static string Palindrome(string word)
    {
        var sb = new StringBuilder();
        for (var index = word.Length - 1; index >= 0; index--)
            sb.Append(word[index]);

        return sb.ToString();
    }
}