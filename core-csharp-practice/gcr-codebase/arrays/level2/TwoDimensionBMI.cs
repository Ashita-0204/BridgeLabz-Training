using System;

class TwoDimensionBMI
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        double[][] personData = new double[number][3];
        string[] weightStatus = new string[number];
        for (int i = 0; i < num; i++)
        {
            while (true)
            {
                Console.Write("Weight");
                personData[i][0] = double.Parse(Console.ReadLine());
                if (personData[i][0] > 0)
                    break;
                Console.WriteLine("Negative");
            }
            while (true)
            {
                Console.Write("Height ");
                personData[i][1] = double.Parse(Console.ReadLine());
                if (personData[i][1] > 0)
                    break;
                Console.WriteLine("Negative");
            }
            // BMI 
            personData[i][2] = personData[i][0] /
                               (personData[i][1] * personData[i][1]);

            // Weight Conditioning
            if (personData[i][2] < 18.5)
                weightStatus[i] = "Underweight";
            else if (personData[i][2] < 25)
                weightStatus[i] = "Normal";
            else if (personData[i][2] < 30)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }
        //final obs
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("BMI " + data[i][2] + " Status: " + status[i]);
        }
    }
}