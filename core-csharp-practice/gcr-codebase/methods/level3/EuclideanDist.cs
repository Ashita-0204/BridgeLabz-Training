using System;

class EuclideanDist
{
    public static double Distance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
    public static double[] LineEquation(double x1, double y1, double x2, double y2)
    {
        double m = (y2 - y1) / (x2 - x1);
        double b = y1 - m * x1;
        return new double[] { m, b };
    }
    public static void Main()
    {
        //inputs
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        //calling dist meth
        double dist = Distance(x1, y1, x2, y2);
        Console.WriteLine("Distance: " + dist);
        //the equation
        double[] eq = LineEquation(x1, y1, x2, y2);
        Console.WriteLine("Line Equation: y = " + eq[0] + "x + " + eq[1]);
    }
}
