using System;
class AddressBookMenu
{
    public static void Main()
    {
        //UC-0 Implementation for welcoming
        Console.WriteLine("Welcome to Address Book Program! ");
        //Calling the menu Class
        AddressBookMenu menu = AddressBookMenu();
        menu.ShowMenu();
    }
}