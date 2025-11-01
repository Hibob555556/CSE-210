using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num = -9999;
        List<int> numbers = [];
        while (num != 0)
        {
            Console.Write("Enter number: ");
            try
            {
                num = int.Parse(Console.ReadLine());
                if (num != 0)
                    numbers.Add(num);
            }
            catch
            {
                Console.WriteLine("Please Input A Valid Whole Number.");
            }
        }
        int sum = numbers.Sum();
        double avg = numbers.Average();
        int lrg = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg:F2}");
        Console.WriteLine($"The largest number is {lrg}");
    }
}