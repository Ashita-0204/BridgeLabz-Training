using System;
class Chocolates
{
    public static int[] meth(int val1, int val2)
    {
        int given = val1 / val2; //total distributed
        int rem = val1 % val2; //remaining
        return new int[] { given, rem };
    }
    public static void Main()
    {
        //inputs
        int numberOfchocolates = int.Parse(Console.ReadLine());
        int numberOfChildren = int.Parse(Console.ReadLine());
        //calling the method
        int[] arr = meth(numberOfChildren, numberOfchocolates);
        //printing
        Console.WriteLine("The total number of chocolates given are " + arr[0] + "and the remaining are " + arr[1]);
    }
}