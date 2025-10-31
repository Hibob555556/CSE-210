using System;

class Program
{
    static void Main(string[] args)
    {
        // Get student grade
        Console.Write("What is you Grade? ");
        float grade = float.Parse(Console.ReadLine());

        // determine grade
        if (grade >= 0)
        {
            string result;
            if (grade >= 90)
            {
                double l_num = Math.Floor(grade) % 10;
                result = l_num < 3 ? "A-" : "A";

            }
            else if (grade >= 80)
            {
                double l_num = Math.Floor(grade) % 10;
                result = l_num >= 7 ? "B+" : "B";
                result = l_num < 3 ? string.Concat(result, "-") : result;
            }
            else if (grade >= 70)
            {
                double l_num = Math.Floor(grade) % 10;
                result = l_num >= 7 ? "C+" : "C";
                result = l_num < 3 ? string.Concat(result, "-") : result;
            }
            else if (grade >= 60)
            {
                double l_num = Math.Floor(grade) % 10;
                result = l_num >= 7 ? "D+" : "D";
                result = l_num < 3 ? string.Concat(result, "-") : result;
            }
            else
            {
                result = "F";
            }

            // Print out grade
            Console.WriteLine($"Your letter grade is: '{result}'.");

            // congratulations or encouragement 
            if (grade >= 70)
            {
                Console.WriteLine("Congrats, you passed!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid grade > 0");
        }
    }
}

// Testing Results
// ==============================
// 99 -> A+
// 94 -> A
// 92 -> A-

// 88 -> B+
// 85 -> B
// 81 -> B-

// 77 -> C+
// 76 -> C
// 70 -> C-

// 69 -> D+
// 64 -> D
// 62 -> D-

// 59 -> F
// 30 -> F
// 0  -> F

// -10 -> Please enter a valid grade > 0
// ==============================