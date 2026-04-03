using System;

class Library
{
    public static void Main()
    {
        Author author = new Author
        {
            // Calling the base class constructor
            Title = "Ferrero",
            PublicationYear = 2026,
            auth = "Nutella",
            Bio = "Catering"
        };

        // Calling the derived class method
        author.DisplayInfo();
    }
}
