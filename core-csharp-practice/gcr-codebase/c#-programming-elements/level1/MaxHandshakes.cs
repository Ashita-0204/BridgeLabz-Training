using System;
public class MaxHandshakes
{
  public static void Main(String[] args)
  {
    Console.WriteLine("Enter the number of Students: "); //Input
    int N = int.Parse(Console.ReadLine());
    int combi = (N * (N - 1)) / 2; //Formula
    Console.WriteLine("Possible no. of handshakes is : " + combi);
  }
}