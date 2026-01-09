using System;
class Dispenser
{
    public static void Main()
    {
        int amount = 880;
        ATM atm;
        Console.WriteLine("Scenario A: With Rs.500 note");
        atm = new ATMWithFive();
        atm.Dispense(amount);
        Console.WriteLine("Scenario B: Without Rs. 500 note");
        atm = new ATMWithoutFive();
        atm.Dispense(amount);
        Console.WriteLine("Scenario C: Fallback ");
        atm = new Limited();
        atm.Dispense(350);
    }

}