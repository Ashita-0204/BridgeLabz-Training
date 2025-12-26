using System;
class Comparision
{
    //boolean method to compare
    public static bool isEqual(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i]) //checking the charact at eaxh index 
            {
                return false;
            }
        }
        return true;
    }
    public static void Main()
    {
        //the inputs
        string str = Console.ReadLine();
        string strr = Console.ReadLine();
        if (isEqual(str, strr)) //method called
        {
            Console.WriteLine("The strings are equal");
        }
        else
        {
            Console.WriteLine("The strings are unequal");
        }
    }
}