namespace TEST_EXPLORER;
/*
 * TODO: тестирования функционала C#
 */
internal class Program
{
    static void Main(string[] args)
    {
        int nums = Factorial(5);
        Console.WriteLine(nums);
    }
    static int Factorial(int x)
    {
        if (x == 1) return x;
        return x * Factorial(x - 1);
    }
}

