using System;
class Frequent
{
    public static void Main()
    {
        string str = Console.ReadLine();
        //maximum based variables
        char maxChar = str[0];
        int maxCount = 0;
        for (int i = 0; i < str.Length; i++)
        {
            int count = 1;
            for (int j = i + 1; j < str.Length; j++)
            {
                if (str[i] == str[j])
                {
                    count++;
                }
            }

            //to find maxchar
            if (count > maxCount)
            {
                maxCount = count;
                maxChar = str[i];
            }
        }
        Console.WriteLine("Most Frequent Character is " + maxChar);
    }
}
