namespace _03._Calculations;
class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());

        if (type == "subtract")
        {
            Subtract(numberOne, numberTwo);
        }
        else if (type == "add")
        {
            Add(numberOne, numberTwo);
        }
        else if (type == "multiply")
        {
            Multiply(numberOne, numberTwo);
        }
        else //divide
        {
            Divide(numberOne, numberTwo);
        }
    }

    static void Subtract(int one, int two)
    {
        Console.WriteLine(one - two);
    }

    static void Add(int one, int two)
    {
        Console.WriteLine(one + two);
    }

    static void Multiply(int one, int two)
    {
        Console.WriteLine(one * two);
    }

    static void Divide(int one, int two)
    {
        Console.WriteLine(one / two);
    }
}

