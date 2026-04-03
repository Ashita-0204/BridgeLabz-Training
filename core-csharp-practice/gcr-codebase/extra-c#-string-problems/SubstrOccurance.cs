using System;

class SubstrOccurance
{
    public static void Main()
    {
        //input
        string str = Console.ReadLine();
        string sub = Console.ReadLine();
        int count = 0;

        for (int i = 0; i <= str.Length - sub.Length; i++)
        {
            bool found = true; //if found
            for (int j = 0; j < sub.Length; j++)
            {
                if (str[i + j] != sub[j])
                {
                    found = false;
                    break;
                }
            }
            if (found)
            {
                count++;
            }
        }

        Console.WriteLine("Occurrences are " + count);
    }
}
