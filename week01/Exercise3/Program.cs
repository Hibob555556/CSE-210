using System;

class Program
{
    static void Main(string[] args)
    {
        int m_number;
        int g_number;
        bool guessed = false;

        Random rand = new();
        m_number = rand.Next(1, 101);

        int count = 0;
        while (!guessed)
        {
            count++;
            Console.Write("What is your guess? ");
            try
            {
                g_number = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Try Again");
                continue;
            }

            if (m_number == g_number)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"Guesses: {count}.");
                Console.Write("Would you like to play again (0 = no, 1 = yes)? ");
                int again = int.Parse(Console.ReadLine());
                if (again != 1)
                {
                    guessed = true;
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    m_number = rand.Next(1, 101);
                    count = 0;
                }
            }
            else if (g_number > m_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
    }
}