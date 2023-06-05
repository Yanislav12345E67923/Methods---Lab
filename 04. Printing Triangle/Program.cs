namespace _04._Printing_Triangle;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        TopPart(n);
        Midle(n);
        BottomPart(n);
    }

    static void TopPart(int n)
    {
        for (int i = 1; i <= n - 1; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }

    static void Midle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void BottomPart(int n)
    {
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}

