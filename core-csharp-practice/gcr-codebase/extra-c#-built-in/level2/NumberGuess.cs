using System;

class NumberGuess
{
    public static int GenerateGuess(int low, int high) //generate guess
    {
        return (low + high) / 2;
    }

    // Gets user feedback (high /low/correct one)
    static string GetFeedback()
    {
        Console.Write("Enter feedback ");
        return Console.ReadLine().ToLower();
    }

    public static void Main()
    {
        int low = 1;
        int high = 100;
        string feedback;
        while (low <= high)
        {
            int guess = GenerateGuess(low, high);
            Console.WriteLine("Computer guesses: " + guess);
            feedback = GetFeedback();
            //binary search 
            if (feedback == "correct")
            {
                Console.WriteLine("Guessed the num");
                break;
            }
            else if (feedback == "high")
            {
                high = guess - 1;
            }
            else if (feedback == "low")
            {
                low = guess + 1;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
