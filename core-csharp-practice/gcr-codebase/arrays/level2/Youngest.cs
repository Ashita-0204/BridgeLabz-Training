using System;

class Youngest
{
    public static void Main()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] age = new int[3];
        int[] height = new int[3];


        for (int i = 0; i < 3; i++) //input age and height
        {
            age[i] = int.Parse(Console.ReadLine());
            height[i] = int.Parse(Console.ReadLine());
        }

        //Calculation
        int youngest = 0;
        int tallest = 0;
        for (int i = 1; i < 3; i++)
        {
            if (age[i] < age[youngest])
            {
                youngest = i;
            }
            if (height[i] < height[youngest])
            {
                tallest = i;
            }
        }

        //printing statement 
        Console.WriteLine("Youngest friend is: " + names[youngest] + " Tallest friend is: " + names[tallest]);
    }
}