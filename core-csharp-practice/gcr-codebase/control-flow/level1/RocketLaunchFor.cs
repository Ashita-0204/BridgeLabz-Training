using System;
class RocketLaunchFor
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine()); //input
        for (int i = num; i >= 1; i--) //decrement loop
        {
            //output
            Console.WriteLine(i);
        }
    }

}