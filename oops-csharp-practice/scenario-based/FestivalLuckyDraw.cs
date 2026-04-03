using System;
class FestivalLuckyDraw
{
    public static void Main()
    {
        int visitors;
        Console.Write("Enter number of visitors: ");
        visitors = int.Parse(Console.ReadLine());

        for (int i = 0; i < visitors; i++)
        {
            Console.Write("Visitor " + i + ", enter your lucky number: ");
            int num;

            // Check for invalid input
            bool isValid = int.TryParse(Console.ReadLine(), out num);

            if (!isValid)
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            // Check divisibility by 3 and 5
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("Congratulations! You won a gift!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
        }

        Console.WriteLine("Lucky Draw Completed! ");
    }
}