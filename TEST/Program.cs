namespace TEST_EXPLORER;
/*
 * TODO: тестирования функционала C#
 */
internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int [10];
        var random = new Random();
        foreach (var m in numbers)
        {
            numbers[m] = random.Next(0,10);
            Console.WriteLine(numbers[m]);
        }
    }
    
}

