using System;

class TwoDimensionalGrades
{
    public static void Main()
    {

        //takes input from the user
        int num = int.Parse(Console.ReadLine());

        int[,] marks = new int[num, 3];
        double[] perc = new double[num];
        char[] grades = new char[num];

        //take marks from the user
        for (int i = 0; i < num; i++)
        {
            marks[i, 0] = int.Parse(Console.ReadLine());
            marks[i, 1] = int.Parse(Console.ReadLine());
            marks[i, 2] = int.Parse(Console.ReadLine());
            //Negation
            if (marks[i, 0] < 0 || marks[i, 1] < 0 || marks[i, 2] < 0)
            {
                Console.WriteLine("Invalid marks! Enter positive value");
                i--;
            }
        }
        //calculation
        for (int i = 0; i < num; i++)
        {
            int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
            perc[i] = total / 3.0;
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
        //printing the output 
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Physics: " + marks[i, 0] + " , Chemistry: " + marks[i, 1] + " , Maths: " + marks[i, 2] + " , Percentage: " + perc[i] + " , Grade: " + grades[i]);
        }
    }
}