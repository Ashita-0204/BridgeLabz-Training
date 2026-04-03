using System;

class Grades
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] physics = new int[n];
        int[] chemistry = new int[n];
        int[] maths = new int[n];
        double[] perc = new double[n];
        char[] grades = new char[n];

        for (int i = 0; i < n; i++)
        {
            physics[i] = int.Parse(Console.ReadLine());
            chemistry[i] = int.Parse(Console.ReadLine());
            maths[i] = int.Parse(Console.ReadLine());
            //Negation
            if (physics[i] < 0 || chemistry[i] < 0 || maths[i] < 0)
            {
                Console.WriteLine("Invalid marks");
                i--;
            }
        }
        //calculation
        for (int i = 0; i < n; i++)
        {
            perc[i] = (physics[i] + chemistry[i] + maths[i]) / 3.0;
            if (perc[i] >= 80)
            {
                grades[i] = 'A';
            }
            else if (perc[i] >= 70)
            {
                grades[i] = 'B';
            }
            else if (perc[i] >= 60)
            {
                grades[i] = 'C';
            }
            else if (perc[i] >= 50)
            {
                grades[i] = 'D';
            }
            else if (perc[i] >= 40)
            {
                grades[i] = 'E';
            }
            else
            {
                grades[i] = 'R';
            }
        }
        //printing the result
        Console.WriteLine("Student Result");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Physics: " + physics[i] + " ,Chemistry: " + chemistry[i] + " ,Maths: " + maths[i] + " , Percentage: " + perc[i] + " ,Grade: " + grades[i]);
        }

    }
}