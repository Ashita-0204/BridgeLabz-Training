public interface IAddress
{
    void SelectAddressBook();
    void AddContact();
    void EditDetail();
    void DeleteContact();
    void MultipleUsers();
    void AddressBook();
    bool isDuplicate(User user);
    void SearchAcrossAddressBooks();
    void ViewByCityOrState();
    void SearchByCityOrState();
    void CountByCityOrState();
    void SortByName();
}
