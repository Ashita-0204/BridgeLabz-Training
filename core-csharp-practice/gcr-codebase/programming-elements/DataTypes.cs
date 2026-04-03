public class DataTypes
{
    public static void Main(String[] args)
    {
        byte num = 2; //byte input
        Console.WriteLine("The number in byte is " + num);
        short num1 = 3200; //short input
        Console.WriteLine("The short value of the number " + num1);
        long num2 = 9000000000L; //long input
        Console.WriteLine("The long value is " + num2);
        float num3 = 2.5F; //float input
        Console.WriteLine("The float decimal value is " + num3);
        double num4 = 78945.632145; //double input
        Console.WriteLine("The double decimal value is " + num4);
        int num5 = 3; //integer input
        Console.WriteLine("The integer number is " + num5);
        char ch = 'c'; //character input
        Console.WriteLine("The character value is " + ch);
        bool isValid = true; //boolean input
        Console.WriteLine("The boolean value is " + isValid);

        //Type Conversions

        //Implicit Conversion(Short->Long)
        int a = 10;
        double b = a;   // int -> double
        Console.WriteLine("The converted value from integer to double is " + b.ToString("0.0"));
        char c = 'A';// char -> int (ASCII)
        int d = c;
        Console.WriteLine("The converted value from char to integer is " + d);

        //Explicit Conversion
        double num6 = 7890.1234;
        int num7 = (int)num6;
        Console.WriteLine("The converted value from double to int is " + num7);

        //using Convert.To
        int r = Convert.ToInt32(13.57);
        Console.WriteLine("The converted value from double to int is " + r);
        bool p = Convert.ToBoolean("true");
        Console.WriteLine("The converted value from string to boolean is " + p);
        char s = Convert.ToChar("T");
        Console.WriteLine("The converted value from string to char is " + s);


    }
}