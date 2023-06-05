namespace _08._Math_Power;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(PowerNumber(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
    }

    static double PowerNumber(double number, double power)
    {
        return Math.Pow(number, power);
    }
}

