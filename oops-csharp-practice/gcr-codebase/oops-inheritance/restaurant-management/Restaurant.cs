using System;
class Restaurant
{
    public static void Main()
    {
        // Creating workers
        Worker chef = new Chef();
        Worker waiter = new Waiter();

        // Performing duties
        chef.PerformDuties();
        waiter.PerformDuties();
    }
}
