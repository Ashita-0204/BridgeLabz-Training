class Author : Book
{
    // Author: Firstname Lastname
    public string auth;
    public string Bio;

    public void DisplayInfo()
    {
        // Calling the base class method
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Year: " + PublicationYear);
        Console.WriteLine("Author: " + auth);
        Console.WriteLine("Bio: " + Bio);
    }
}
