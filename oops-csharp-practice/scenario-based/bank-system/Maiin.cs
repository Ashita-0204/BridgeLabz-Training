using System;

class Maiin
{
    // Program entry point
    public static void Main()
    {
        AccountDb db = new AccountDb(10);
        Interfacee ui = new Interfacee(db);
        ui.Start();
    }
}
