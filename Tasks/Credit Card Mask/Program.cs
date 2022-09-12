using System.Text;

var str = Kata.Maskify("Hello My Friends");
Console.WriteLine(str);
str = Kata.Maskify("He");
Console.WriteLine(str);

public static class Kata
{
    public static string? Maskify(string cc)
    {
        var sb = new StringBuilder();
        for (var index = 0; index < cc.Length; index++)
            sb.Append(cc.Length - index > 4 ? '#' : cc[index]);

        return sb.ToString();
    }
}