using System;

class Bonus
{
    public static void Main()
    {
        //initialise 
        double[] salary = new double[10];
        double[] service = new double[10];
        double[] bonus = new double[10];
        double[] arr = new double[10];

        double totalbonus = 0;
        double totalSalary = 0;
        double newSalary = 0;

        for (int i = 0; i < 10; i++)
        {
            salary[i] = double.Parse(Console.ReadLine());
            service[i] = double.Parse(Console.ReadLine());
            if (salary[i] <= 0 || service[i] < 0)
            {
                Console.WriteLine("Invalid Input");
                i--;
            }
        }
        for (int i = 0; i < 10; i++)
        {
            if (service[i] > 5)
            {
                bonus[i] = salary[i] * 0.05;
            }
            else
            {
                bonus[i] = salary[i] * 0.02;
            }
            arr[i] = salary[i] + bonus[i];

            totalbonus += bonus[i];
            totalSalary += salary[i];
            newSalary += arr[i];
        }
        Console.WriteLine("Total Old Salary: " + totalSalary);
        Console.WriteLine("Total Bonus: " + totalbonus);
        Console.WriteLine("Total new Salary: " + newSalary);

    }
}