namespace _10._Multiply_Evens_by_Odds;
class Program
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        int abs = int.Parse(number);
        number = Math.Abs(abs).ToString();

        int evenSum = GetSumOfEvenDigits(number);
        int oddSum = GetSumOfOddDigits(number);

        Console.WriteLine(GetMultipleOfEvenAndOdds(evenSum, oddSum));
    }

    static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
    {
        return evenSum * oddSum;
    }

    static int GetSumOfEvenDigits(string n)
    {
        int sum = 0;
        for (int i = 0; i < n.Length; i++)
        {
            if (int.Parse(n[i].ToString()) % 2 == 0)
            {
                sum += int.Parse(n[i].ToString());
            }
        }

        return sum;
    }

    static int GetSumOfOddDigits(string n)
    {
        int sum = 0;
        for (int i = 0; i < n.Length; i++)
        {
            if (int.Parse(n[i].ToString()) % 2 != 0)
            {
                sum += int.Parse(n[i].ToString());
            }
        }

        return sum;
    }
}

