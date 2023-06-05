namespace _07._Repeat_String;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(RepeatString(Console.ReadLine(), int.Parse(Console.ReadLine())));
    }

    static string RepeatString(string text, int times)
    {
        string result = string.Empty;
        for (int i = 0; i < times; i++)
        {
            result += text;
        }
        return result;
    }
}

