public interface ICinena
{
    void AddMovie(string title, string time);
    bool searchMovie(string key);
    void displayAllMovies();
    void GenerateReport();
}