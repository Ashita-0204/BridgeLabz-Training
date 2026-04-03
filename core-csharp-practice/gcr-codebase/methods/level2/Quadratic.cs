using System;

class Quadratic
{
    public static double[] Roots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta < 0)
        {
            return new double[0];
        }
        if (delta == 0)
        {
            return new double[] { -b / (2 * a) };
        }

        double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
        return new double[] { root1, root2 };
    }

    public static void Main()
    {
        //input values
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double[] arr = Roots(a, b, c);

        if (arr.Length == 0)
        {
            Console.WriteLine("No real roots");
        }
        else
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Root: " + i);
            }
    }
}
