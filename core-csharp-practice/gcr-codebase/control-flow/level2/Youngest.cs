using System;
class YoungestAndTallestFriend
{
    public static void Main(string[] args)
    {
        Console.Write("Amar's age: ");
        int amar = int.Parse(Console.ReadLine());
        Console.Write("Akbar's age: ");
        int akbar = int.Parse(Console.ReadLine());
        Console.Write("Anthony's age: ");
        int anthony = int.Parse(Console.ReadLine());
        Console.Write("Amar's height: ");
        int amarHeight = int.Parse(Console.ReadLine());
        Console.Write("Akbar's height: ");
        int akbarHeight = int.Parse(Console.ReadLine());
        Console.Write("Anthony's height: ");
        int anthonyHeight = int.Parse(Console.ReadLine());
        // condition for youngest
        string youngestFriend;
        if (amar < akbar && amar < anthony)
        {
            youngestFriend = "Amar";
        }
        else if (akbar < amar && akbar < anthony)
        {
            youngestFriend = "Akbar";
        }
        else if (anthony < amar && anthony < akbar)
        {
            youngestFriend = "Anthony";
        }
        else
        {
            youngestFriend = "There is a tie for the youngest friend";
        }
        //condition for tallest 
        string tallestFriend;
        if (amarHeight > akbarHeight && amarHeight > anthonyHeight)
        {
            tallestFriend = "Amar";
        }
        else if (akbarHeight > amarHeight && akbarHeight > anthonyHeight)
        {
            tallestFriend = "Akbar";
        }
        else if (anthonyHeight > amarHeight && anthonyHeight > akbarHeight)
        {
            tallestFriend = "Anthony";
        }
        else
        {
            tallestFriend = "There is a tie for the tallest friend";
        }
        Console.WriteLine("Youngest Friend: " + youngestFriend);
        Console.WriteLine("Tallest Friend: " + tallestFriend);
    }
}