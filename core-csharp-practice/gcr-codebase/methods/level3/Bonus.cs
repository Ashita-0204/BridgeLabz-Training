using System;

class Bonus
{
    public static int[,] GenerateData()
    {
        Random rand = new Random();
        int[,] data = new int[10, 2]; // salary, years
        for (int i = 0; i < 10; i++)
        {
            data[i, 0] = rand.Next(10000, 100000);
            data[i, 1] = rand.Next(1, 11);
        }
        return data;
    }

    public static double[,] CalculateBonus(int[,] data)
    {
        double[,] result = new double[10, 3]; // old, bonus, new

        for (int i = 0; i < 10; i++)
        {
            double bonusRate = data[i, 1] > 5 ? 0.05 : 0.02;
            double bonus = data[i, 0] * bonusRate;
            double newSalary = data[i, 0] + bonus;

            result[i, 0] = data[i, 0];
            result[i, 1] = bonus;
            result[i, 2] = newSalary;
        }
        return result;
    }

    public static void Main()
    {
        int[,] emp = GenerateData();
        double[,] res = CalculateBonus(emp);
        double totalOld = 0, totalBonus = 0, totalNew = 0;
        Console.WriteLine("OldSalary\tBonus\tNewSalary");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(
                res[i, 0] + "\t" +
                res[i, 1] + "\t" +
                res[i, 2]
            );

            totalOld += res[i, 0];
            totalBonus += res[i, 1];
            totalNew += res[i, 2];
        }

        Console.WriteLine("Total Old Salary: " + totalOld);
        Console.WriteLine("Total Bonus: " + totalBonus);
        Console.WriteLine("Total New Salary: " + totalNew);
    }
}
