using System;
class ATM
{
    protected int[] denomination;
    protected int[] notes;
    //constructor
    public ATM(int[] denoms)
    {
        denomination = denoms;
        notes = new int[denoms.Length];
    }
    //virtual method
    public virtual void Dispense(int amount)
    {
        int remaining = amount;

        //Calculating number od notes
        for (int i = 0; i < denomination.Length; i++)
        {
            if (remaining >= denomination[i])
            {
                notes[i] = remaining / denomination[i];
                remaining = remaining % denomination[i];
            }
        }

        //if exact change not possible
        if (remaining != 0)
        {
            Console.WriteLine("Exact change not possible! ");
            Console.WriteLine("Remaining amount is " + remaining);
            return;
        }

        //Display
        Console.WriteLine("Amount Dispensed " + amount);
        for (int i = 0; i < denomination.Length; i++)
        {
            if (notes[i] > 0)
            {
                Console.WriteLine("Rs. " + denomination[i] + " has count of " + notes[i] + " notes.");
            }
        }
    }
}