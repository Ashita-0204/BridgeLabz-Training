using System;

class Youngest
{
    public static int FindYoungest(int[] age)
    {
        int idx = 0;
        for (int i = 1; i < age.Length; i++)
            if (age[i] < age[idx]) //to find youngest
            {
                idx = i;
            }
        return idx;
    }

    static int FindTallest(double[] height)
    { //for tallest
        int idx = 0;
        for (int i = 1; i < height.Length; i++)
            if (height[i] > height[idx])
            {
                idx = i;
            }
        return idx;
    }
    public static void Main()
    {
        //to return names of the tallest and youngest
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] age = new int[3];
        double[] height = new double[3];

        for (int i = 0; i < 3; i++)
        {
            age[i] = int.Parse(Console.ReadLine());
            height[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Youngest: " + names[FindYoungest(age)]); //calling youngest method
        //calling tallest method
        Console.WriteLine("Tallest: " + names[FindTallest(height)]);
    }
}
