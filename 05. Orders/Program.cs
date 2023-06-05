namespace _05._Orders;
class Program
{
    static void Main(string[] args)
    {
        double price = Calculation(Console.ReadLine(), int.Parse(Console.ReadLine()));
        Console.WriteLine($"{price:f2}");
    }

    static double Calculation(string product, int quantity)    
    {
        if (product == "coffee")
        {
            return quantity * 1.50;
        }
        else if (product == "water")
        {
            return quantity * 1.00;
        }
        else if (product == "coke")
        {
            return quantity * 1.40;
        }
        else // snacks
        {
            return quantity * 2.00;
        }
    }
}

