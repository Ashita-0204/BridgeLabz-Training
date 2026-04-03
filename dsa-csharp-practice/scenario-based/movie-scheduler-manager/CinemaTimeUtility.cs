using System;
using System.Text.RegularExpressions;
class CinemaTimeUtility : ICinema
{

    private Movie[] movie = new Movie[1001];
    private int count = 0;


    //Add Movie
    public void AddMovie()
    {
        Console.Write("Enter movie title: ");
        string title = Console.ReadLine();
        Console.Write("Enter show time: ");
        string time = Console.ReadLine();

        if (count >= movie.Length)
        {
            Console.WriteLine("Can't add more movies");
            return;
        }
        movie[count] = new Movie(title, time);
        count++;
    }

    //search movie
    public bool searchMovie()
    {
        Console.Write("Enter keyword to search: ");
        string key = Console.ReadLine();
        for (int i = 0; i < movie.Length; i++)
        {
            if (movie[i].title.Contains(key))
            {
                Console.WriteLine("Movie is found in records");
                return true;
            }

        }
        return false;
    }

    //display 
    public void displayAllMovies()
    {
        for (int i = 0; i < movie.Length; i++)
        {
            Console.WriteLine(movie[i].title + " plays at " + movie[i].showTime);
        }
    }
    public void GenerateReport()
    {
        Movie[] report = new Movie[count];

        for (int i = 0; i < count; i++)
            report[i] = movie[i];

        Console.WriteLine("--- Printable Movie Report ---");
        foreach (Movie i in report)
        {
            Console.WriteLine(i.Title + " plays at " + movie.showTime);
        }
    }

}
