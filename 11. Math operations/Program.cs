namespace _11._Math_operations;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MathOperation(double.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
    }

    static double MathOperation(double one, char typeOfOperation, double two)
    {
        if (typeOfOperation == '*')
        {
            return one * two;
        }
        else if (typeOfOperation == '+')
        {
            return one + two;
        }
        else if (typeOfOperation == '-')
        {
            return one - two;
        }
        else
        {
            return one / two;
        }
    }
}

