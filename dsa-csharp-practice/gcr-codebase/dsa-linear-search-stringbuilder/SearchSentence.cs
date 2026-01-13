using System;

class SearchSentence
{
    public static void Main()
    {
        Console.Write("Enter number of sentences: ");
        int n = int.Parse(Console.ReadLine());

        string[] sentences = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter sentence: ");
            sentences[i] = Console.ReadLine();
        }
        Console.Write("Enter word to search: ");
        string word = Console.ReadLine();

        int index = -1;

        for (int i = 0; i < n; i++)
        {
            if (sentences[i].ToLower().Contains(word.ToLower()))
            {
                index = i;
                break;
            }
        }

        if (index != -1)
            Console.WriteLine("Word found in sentence index: " + index);
        else
            Console.WriteLine("Word not found");
    }
}
