class Application
{
    public static void Main()
    {
        IBrowserBuddy browser = new BrowserBuddy();

        browser.Visit("google.com");
        browser.Visit("youtube.com");
        browser.Visit("github.com");

        browser.Back();
        browser.Forward();

        browser.CloseTab();
        browser.ReopenTab();

        Console.WriteLine("Current Page: " + browser.GetCurrentPage());
    }
}