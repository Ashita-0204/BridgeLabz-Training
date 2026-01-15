using System;
using System.Net;
using System.Reflection.Metadata;
class AddressBookUtility : IAddress
{
    private LinkedList<User> contacts = new LinkedList<User>();
    static User[] addressArray = new User[1001];
    static AddressBookUtility[] addressBooks = new AddressBookUtility[10];
    static string[] addressBookNames = new string[10];
    static int bookCount = 0;
    static AddressBookUtility currentBook;
    static int count = 0;
    private int contactCount = 0;

    //UC-2 Implementation for adding a new contact 
    public void AddContact()
    {
        User user = new User();
        Console.Write("Enter First Name: ");
        user.FirstName = Console.ReadLine();
        Console.Write("Enter Last Name: ");
        user.LastName = Console.ReadLine();
        Console.Write("Enter Address: ");
        user.Address = Console.ReadLine();
        Console.Write("Enter City: ");
        user.City = Console.ReadLine();
        Console.Write("Enter State: ");
        user.State = Console.ReadLine();
        Console.Write("Enter Zip: ");
        user.Zip = Console.ReadLine();
        Console.Write("Enter Email: ");
        user.Email = Console.ReadLine();
        Console.Write("Enter Phone Number: ");
        user.PhoneNum = int.Parse(Console.ReadLine()!);
        contacts.AddLast(user);
        Console.WriteLine("Contact Added Successfully!");
    }

    //UC-3 Implementation to edit the Contact's name
    public void EditDetail()
    {
        Console.Write("Enter the Name ");
        string name = Console.ReadLine();
        foreach (User user in contacts)
        {
            if (user.FirstName == name)
            {
                Console.WriteLine("The field to be edited: ");
                Console.WriteLine("1. Address");
                Console.WriteLine("2. City");
                Console.WriteLine("3. State");
                Console.WriteLine("4. Zip");
                Console.WriteLine("5. Email");
                Console.WriteLine("6. Phone Number");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter new Address: ");
                        user.Address = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Enter new city: ");
                        user.City = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Enter new State: ");
                        user.State = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Enter new Zip: ");
                        user.Zip = Console.ReadLine();
                        break;
                    case 5:
                        Console.Write("Enter new Email: ");
                        user.Email = Console.ReadLine();
                        break;
                    case 6:
                        Console.Write("Enter new Phone Number: ");
                        user.PhoneNum = int.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        return;
                }
            }
            else
            {
                Console.WriteLine("Contact not Found");
            }
        }

    }

    //UC-4 Implementation to Delete a user
    public void DeleteContact()
    {
        Console.Write("Enter the First and Last name ");
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        LinkedList<User> curr = contacts.First;
        bool flag = false;
        while (curr != null)
        {
            if (curr.Value.FirstName == firstName && curr.Value.LastName == lastName)
            {
                contacts.Remove(curr);
                Console.ReadLine("The User is deleted.");
                flag = true;
                break;
            }
            curr = curr.Next;
        }
        if (!flag)
        {
            Console.WriteLine("User not found");
        }

    }

    //UC-5 Implementation to add Multiple users
    public void MultipleUsers()
    {
        if (count >= addressArray.Length)
        {
            Console.WriteLine("This address book is full");
            return;
        }
        User user = new User();
        Console.Write("Enter First Name: ");
        user.FirstName = Console.ReadLine();
        Console.Write("Enter Last Name: ");
        user.LastName = Console.ReadLine();
        Console.Write("Enter Address: ");
        user.Address = Console.ReadLine();
        Console.Write("Enter City: ");
        user.City = Console.ReadLine();
        Console.Write("Enter State: ");
        user.State = Console.ReadLine();
        Console.Write("Enter Zip: ");
        user.Zip = Console.ReadLine();
        Console.Write("Enter Email: ");
        user.Email = Console.ReadLine();
        Console.Write("Enter Phone Number: ");
        user.PhoneNum = int.Parse(Console.ReadLine()!);

        addressArray[count] = user;
        count++;
        Console.WriteLine("Added User");
    }

    //UC-6 Implementation for different AddressBooks
    public void AddressBooks()
    {
        if (bookCount > addressBookNames.Length)
        {
            Console.WriteLine("Can't add more Address Books!");
            return;
        }
        Console.ReadLine("Enter the Address Book Name: ");
        string name = Console.ReadLine();
        for (int i = 0; i < bookCount; i++)
        {
            if (addressBook[i] == name)
            {
                Console.WriteLine("Address Book already exists!");
                return;
            }
        }
        addressBookNames[bookCount] = name;
        addressBooks[bookCount] = new AddressBookUtility();
        bookCount++;
        Console.WriteLine("Address Book added successfully!");
    }
    public void SelectAddressBook()
    {
        Console.Write("Enter Address Book Name: ");
        string name = Console.ReadLine();

        for (int i = 0; i < bookCount; i++)
        {
            if (addressBookNames[i] == name)
            {
                currentBook = addressBooks[i];
                Console.WriteLine("Address Book selected successfully!");
                return;
            }
        }

        Console.WriteLine("Address Book not found!");
    }


    //UC-7 Implementation to check for Duplicates
    public bool isDuplicate(User user)
    {
        foreach (User existing in contacts)
        {
            if (existing.Equals(user))
            {
                return true; // duplicate found
            }
        }
        return false;
    }
    // UC-8 Implementation to search person by City or State across multiple Address Books
    public void SearchAcrossAddressBooks()
    {
        Console.WriteLine("Search by:");
        Console.WriteLine("1. City");
        Console.WriteLine("2. State");
        Console.Write("Enter choice: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter name: ");
        string searchVal = Console.ReadLine();
        bool found = false;
        for (int i = 0; i < bookCount; i++)
        {
            AddressBookUtility book = addressBooks[i];
            for (int j = 0; j < book.contactCount; j++)
            {
                User u = book.contacts[j];
                if ((choice == 1 && u.City == searchValue) || (choice == 2 && u.State == searchValue))
                {
                    Console.WriteLine(u + " AddressBook: " + addressBookNames[i]);
                    found = true;
                }
            }
        }
        if (!found)
            Console.WriteLine("No match found");
    }
    // UC-9 Implementation to view persons by City or State
    public void ViewByCityOrState()
    {
        Console.WriteLine("View by:");
        Console.WriteLine("1. City");
        Console.WriteLine("2. State");
        Console.Write("Enter choice: ");
        int choice = int.Parse(Console.ReadLine());
        Console.Write("Enter name: ");
        string value = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < bookCount; i++)
        {
            AddressBookUtility book = addressBooks[i];
            for (int j = 0; j < book.contactCount; j++)
            {
                User u = book.contacts[j];
                if ((choice == 1 && u.City == value) || (choice == 2 && u.State == value))
                {
                    Console.WriteLine(u);
                    found = true;
                }
            }
        }
        if (!found)
            Console.WriteLine("No records found");
    }

    // UC-10 Implementation to count contacts by City or State across all Address Books  
    public void CountByCityOrState()
    {
        Console.WriteLine("Count by:");
        Console.WriteLine("1. City");
        Console.WriteLine("2. State");
        Console.Write("Enter choice: ");
        int choice = int.Parse(Console.ReadLine());
        Console.Write("Enter value: ");
        string value = Console.ReadLine();

        int count = 0;
        for (int i = 0; i < bookCount; i++)
        {
            AddressBookUtility book = addressBooks[i];
            for (int j = 0; j < book.contactCount; j++)
            {
                switch (choice)
                {
                    case 1:
                        if (book.contacts[j].City == value)
                            count++;
                        break;

                    case 2:
                        if (book.contacts[j].State == value)
                            count++;
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        return;
                }
            }
        }

        Console.WriteLine("Total contacts count: " + count);
    }

    // UC-11 Implementation to Sort contacts alphabetically 
    public void SortByName()
    {
        for (int i = 0; i < contactCount - 1; i++)
        {
            for (int j = i + 1; j < contactCount; j++)
            {
                if (string.Compare(contacts[i].FirstName, contacts[j].FirstName) > 0)
                {
                    User temp = contacts[i];
                    contacts[i] = contacts[j];
                    contacts[j] = temp;
                }
            }
        }
        Console.WriteLine("Sorted alphabetically by name");
    }


}