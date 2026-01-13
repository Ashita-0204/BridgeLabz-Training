public interface IShelf
{
    void AddBooks(string title, string author);
    void sortBooks();
    bool SearchByAuthor();
    void ExportBooks();
}