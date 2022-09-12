using System.Text;

var str = Kata.GetUnique(new [] {1, 1, 1, 1, 2, 1});
Console.WriteLine(str);
str = Kata.GetUnique(new[] {-4, 4, 4, 4, 4});
Console.WriteLine(str);

public class Kata
{
    public static int GetUnique(IEnumerable<int> numbers)
    {
        var dict = new Dictionary<int, int>();
        var previewItem = 0;
        foreach (var number in numbers)
        {
            if (!dict.ContainsKey(number) && dict.ContainsKey(previewItem) && dict[previewItem] > 1)
                return number;

            if (!dict.ContainsKey(number))
                dict.Add(number, 0);

            dict[number]++;
            previewItem = number;
        }

        return dict.First(item => item.Value == 1).Key;
    }
}
