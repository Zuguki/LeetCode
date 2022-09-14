using System;
using System.Collections.Generic;
using System.Linq;

Console.ReadKey();

public class Deadfish
{
    private static readonly List<ICommand> _commands = new() {new Increment(), new Decrement(), new Pow(), new OutPut()};
    
    public static int[] Parse(string data)
    {
        var number = 0;
        var result = new List<int>();
        foreach (var sym in data)
        {
            number = _commands.First(command => command.Name == sym).Execute(number);
            if (sym == 'o')
                result.Add(number);
        }

        return result.ToArray();
    }
}

public interface ICommand
{
    char Name { get; }
    int Execute(int number);
}

public class Increment : ICommand
{
    public char Name => 'i';
    public int Execute(int number) => number + 1;
}

public class Decrement : ICommand
{
    public char Name => 'd';
    public int Execute(int number) => number - 1;
}

public class Pow : ICommand
{
    public char Name => 's';
    public int Execute(int number) => number * number;
}

public class OutPut : ICommand
{
    public char Name => 'o';
    public int Execute(int number) => number;
}