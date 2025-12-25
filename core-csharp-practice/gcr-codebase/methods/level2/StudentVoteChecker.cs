using System;
using System;

class StudentVoteChecker
{
    public static bool CanStudentVote(int age)
    {
        //Validating conditions
        if (age < 0)
        {
            return false;
        }
        if (age < 18)
        {
            return false;
        }
        return true;
    }

    public static void Main()
    {
        int[] arr = new int[10]; //new arr
        for (int i = 0; i < 10; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (CanStudentVote(arr[i])) //if valid
            {
                Console.WriteLine("Can Vote");
            }
            else //if not
            {
                Console.WriteLine("Cannot Vote");
            }
        }
    }
}
