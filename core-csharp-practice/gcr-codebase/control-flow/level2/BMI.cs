using System;
class BMI
{
    public static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        // Converting
        double heightM = height / 100;
        // Calculating BMI
        double bmi = weight / (heightM * heightM);
        Console.WriteLine("Your BMI is: " + bmi);
        // Conditioning
        if (bmi <= 18.4)
        {
            Console.WriteLine("Underweight");
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("Normal");
        }
        else if (bmi >= 25.0 && bmi <= 39.9)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");
        }
    }
}