namespace _09._Greater_of_Two_Values;
class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();

        if (type == "int")
        {
            GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }
        else if (type == "string")
        {
            GetMax(Console.ReadLine(), Console.ReadLine());
        }
        else
        {
            GetMax(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
        }
    }

    static void GetMax(int one, int two)
    {
        if (one > two)
        {
            Console.WriteLine(one);
        }
        else
        {
            Console.WriteLine(two);
        }
    }

    static void GetMax(string one, string two)
    {
        int compareto = one.CompareTo(two);
        if (compareto > 0)
        {
            Console.WriteLine(one);
        }
        else
        {
            Console.WriteLine(two);
        }
    }

    static void GetMax(char one, char two)
    {
        int oneValue = (int)one;
        int twoValue = (int)two;        
        if (oneValue > twoValue)
        {
            Console.WriteLine(one);
        }        
        else
        {
            Console.WriteLine(two);
        }
    }
}

