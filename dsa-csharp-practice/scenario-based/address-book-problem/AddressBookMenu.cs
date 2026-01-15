class AddressBookMenu
{
    public void ShowMenu()
    {
        IAddress address = new AddressBookUtility();
        int choice;

        do
        {
            Console.WriteLine("\n===== ADDRESS BOOK MENU =====");
            Console.WriteLine("1. Create Address Book");
            Console.WriteLine("2. Select Address Book");
            Console.WriteLine("3. Add Contact");
            Console.WriteLine("4. Edit Contact");
            Console.WriteLine("5. Delete Contact");
            Console.WriteLine("6. Add Multiple Users");
            Console.WriteLine("7. Search Person Across Address Books");
            Console.WriteLine("8. View Persons by City or State");
            Console.WriteLine("9. Count Persons by City or State");
            Console.WriteLine("10. Sort Contacts by Name");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine()!);


            switch (choice)
            {
                case 1:
                    address.AddressBook();
                    break;

                case 2:
                    address.SelectAddressBook();
                    break;

                case 3:
                    address.AddContact();
                    break;

                case 4:
                    address.EditDetail();
                    break;

                case 5:
                    address.DeleteContact();
                    break;

                case 6:
                    address.MultipleUsers();
                    break;

                case 7:
                    address.SearchAcrossAddressBooks();
                    break;

                case 8:
                    address.ViewByCityOrState();
                    break;

                case 9:
                    address.CountByCityOrState();
                    break;

                case 10:
                    address.SortByName();
                    break;

                case 0:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 0);
    }
}