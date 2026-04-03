using System;
class Grades
{
    public static void Main()
    {
        int phy = int.Parse(Console.ReadLine());
        int maths = int.Parse(Console.ReadLine());
        int chem = int.Parse(Console.ReadLine());
        int perc = (maths + phy + chem) / 300 * 100; //calculation of percentage
        if (perc >= 80) //conditions for grading
        {
            Console.WriteLine("above agency-normalized students with average " + avg);
        }
        else if (perc >= 70 || perc <= 79)
        {
            Console.WriteLine("agency-normalized students with average " + avg);
        }
        else if (perc >= 60 || perc <= 69)
        {
            Console.WriteLine("below, but approaching agency-normalized students with average " + avg);
        }
        else if (perc >= 50 || perc <= 59)
        {
            Console.WriteLine("well below agency-normalized students with average " + avg);
        }
        else if (perc >= 40 || perc <= 49)
        {
            Console.WriteLine("tpo below agency-normalized students with average " + avg);
        }
        else
        {

            Console.WriteLine("Remedial Standards students with average " + avg);

        }
    }
}