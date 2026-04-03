using System;
public class DistanceInYards
{
  public static void Main(String[] args)
  {
    //input
    Console.WriteLine("Enter the distance in feet: ");
    double d = double.Parse(Console.ReadLine());
    double dis_yards = d / 3; //Calculation
    double dis_miles = dis_yards / 1760;
    Console.WriteLine("Your height in feet is " + d + " while in yards is " + dis_yards + " and in miles is " + dis_miles);
  }
}