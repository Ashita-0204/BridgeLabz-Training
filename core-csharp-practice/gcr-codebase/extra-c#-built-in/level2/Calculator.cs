using System;

class Calculator
{
    //methods for various operation
    public static double Add(double num1, double num2)
    {
        return num1 + num2;
    }
    public static double Sub(double num1, double num2)
    {
        return num1 - num2;
    }
    public static double Mul(double num1, double num2)
    {
        return num1 * num2;
    }
    public static double Div(double num1, double num2)
    {
        return num1 / num2;
    }

    public static void Main()
    {
        Console.Write("Enter two numbers: ");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Enter operation");
        char oper = Console.ReadLine()[0];
        //switch case for operation
        switch (oper)
        {
            case '+':
                Console.WriteLine(Add(num1, num2));
                break;
            case '-':
                Console.WriteLine(Sub(num1, num2));
                break;
            case '*':
                Console.WriteLine(Mul(num1, num2));
                break;
            case '/':
                Console.WriteLine(Div(num1, num2));
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }
    }
}
