class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter your value, silly goose: ");
        string input = Console.ReadLine();

        int n = Convert.ToInt32(input);
        
        listPrimes(n);
    }
    static bool IsThatYouOptimus(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i < num; i++)
            if (num % i == 0)
                return false;

        return true;
    }
    static void listPrimes(int num)
    {
        for (int i = 2; i <= num; i++)
        {
            if (IsThatYouOptimus(i))
                Console.Write(i + " ");
        }
        if (num <= 1)
        {
            Console.WriteLine("Why are you like this? You know that's not appropriate.");
        }
    }
}