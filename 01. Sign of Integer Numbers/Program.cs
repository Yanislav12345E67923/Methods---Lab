namespace _01._Sign_of_Integer_Numbers;
class Program
{
    static void Main(string[] args)
    {
        string result = SignOfIntegerNumbers(int.Parse(Console.ReadLine()));
        Console.WriteLine(result);
    }

    static string SignOfIntegerNumbers(int n)
    {
        if (n > 0)
            return $"The number {n} is positive.";
        else if (n < 0)
            return $"The number {n} is negative.";
        else
            return $"The number {n} is zero.";
    }
}

