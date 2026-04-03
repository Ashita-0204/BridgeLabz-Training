using System;
class Calculator
{
    public static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter operator:"); //choose any
        string operand = Console.Readline();
        switch (operand) //different cases
        {
            case "+":
                Console.WriteLine("Result = " + (num1 + num2));
                break;
            case "-":
                Console.WriteLine("Result = " + (num1 - num2));
                break;
            case "*":
                Console.WriteLine("Result = " + (num1 * num2));
                break;
            case "/":
                Console.WriteLine("Result = " + (num1 / num2));
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}