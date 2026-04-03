using System;

class BMI
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        //initialising all array
        double[] weight = new double[num];
        double[] height = new double[num];
        double[] bmi = new double[num];
        string[] status = new string[num];
        //bmi calculation
        for (int i = 0; i < num; i++)
        {
            weight[i] = double.Parse(Console.ReadLine());
            height[i] = double.Parse(Console.ReadLine());
            bmi[i] = weight[i] / (height[i] * height[i]);
            //conditioning 
            if (bmi[i] <= 18.4)
            {
                status[i] = "Underweight";
            }
            else if (bmi[i] <= 24.9)
            {
                status[i] = "Normal";
            }
            else if (bmi[i] <= 39.9)
            {
                status[i] = "Overweight";
            }
            else
            {
                status[i] = "Obese";
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("BMI is " + bmi[i] + " Status: " + status[i]);
        }
    }
}