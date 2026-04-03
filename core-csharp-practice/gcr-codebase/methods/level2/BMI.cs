using System;

class BMI
{
    public static double CalculateBMI(double weight, double height)
    {
        double heightM = height / 100;
        return weight / (heightM * heightM); //calculating
    }

    static string GetStatus(double bmi) //to check status
    {
        if (bmi < 18.5)
        {
            return "Underweight";
        }
        if (bmi < 25)
        {
            return "Normal";
        }
        if (bmi < 30)
        {
            return "Overweight";
        }
        return "Obese";
    }

    static void Main()
    {
        double[,] data = new double[10, 3];
        string[] status = new string[10];

        for (int i = 0; i < 10; i++)
        {
            data[i, 0] = double.Parse(Console.ReadLine());
            data[i, 1] = double.Parse(Console.ReadLine());

            data[i, 2] = CalculateBMI(data[i, 0], data[i, 1]);
            status[i] = GetStatus(data[i, 2]);
        }

        for (int i = 0; i < 10; i++)
            Console.WriteLine("Weight is " + data[i, 0] + " Height " + data[i, 1] + "BMI " + data[i, 2] + "Status" + status[i]);
    }
}
