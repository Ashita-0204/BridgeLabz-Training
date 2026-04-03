using System;
public class Fees
{
    public static void Main(String[] args)
    {
        double fee = 125000;
        double discountPercent = 10;
        // calculate discount amount
        double discount = (discountPercent / 100) * fee;
        //calculate discounted fee
        double discountedfee = fee - discount;
        Console.WriteLine("The discount amount is INR " + discount + " and final dicounted fee is INR " + discountedfee);
    }
}