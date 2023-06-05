namespace _06._Calculate_Rectangle_Area;
class Program
{
    static void Main(string[] args)
    {
        int result = RectagleArea(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        Console.WriteLine(result);
    }

    static int RectagleArea(int a, int b)
    {
        return a * b;
    }
}

