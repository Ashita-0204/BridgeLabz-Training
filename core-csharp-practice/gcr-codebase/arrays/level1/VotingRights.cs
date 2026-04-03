using System;
class VotingRights
{
    public static void Main()
    {
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                Console.WriteLine("Invalid Age");
            }
            else if (arr[i] >= 18)
            {
                Console.WriteLine("The student with age " + arr[i] + " can vote ");
            }
            else
            {
                Console.WriteLine("The student with age " + arr[i] + " cannot vote ");
            }
        }

    }
}