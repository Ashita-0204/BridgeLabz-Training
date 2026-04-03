using System;

class GCDLCM
{
    public static int GCD(int num1, int num2)
    { //for gcd 
        while (num2 != 0)
        {
            int temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }
        return num1;
    }
    //method for lcm
    public static int LCM(int num1, int num2)
    {
        return (num1 * num2) / GCD(num1, num2);
    }

    public static void Main()
    {
        Console.Write("Enter two nums");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        //calling method
        Console.WriteLine("GCD is" + GCD(num1, num2));
        Console.WriteLine("LCM is " + LCM(num1, num2));
    }
}
