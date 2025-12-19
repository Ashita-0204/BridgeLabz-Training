using System;
class Fees
{
    static void Main(string[] args)
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