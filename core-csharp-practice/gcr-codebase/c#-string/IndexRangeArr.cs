using System;

class IndexRangeArr
{
    public static void Main()
    {
        try
        { //try block
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[6]);
        }
        catch (IndexOutOfRangeException)
        { //catch block
            Console.WriteLine("Index is out of Range");
        }
    }
}
