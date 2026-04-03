public interface IBrowserTab
{
    void Visit(string url);
    void Back();
    void Forward();
    void CloseTab();
    void ReopenTab();
    string GetCurrentPage();
}
