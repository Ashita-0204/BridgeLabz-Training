using System;
class SentenceFormatter
{

    public static string Format(string input)
    {
        if (input.Length == 0)
        {
            return ""; //if len ==0
        }
        string res = "";
        bool capital = true;
        bool space = false;

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];
            if (ch == ' ')
            {
                if (space)
                {
                    res += ch;  //add charac without space
                    space = false;
                }
                continue;
            }
            if (capital && ch >= 'a' && ch <= 'z')
            {
                ch = (char)(ch - 32); // uppercase
                capital = false;
            }
            else
            {
                capital = false;
            }

            res += ch;
            space = true;

            // After punctuation
            if (ch == '.' || ch == '?' || ch == '!')
            {
                capital = true;
                res += ' ';
                space = false;
            }
        }

        return res;

    }

    public static int Count(string str)
    {
        int count = 0;
        bool present = false;

        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (ch != ' ' && ch != '.' && ch != ',' && ch != '!' && ch != '?') //only a letter
            {
                if (!present) //non repeating word
                {
                    count++; //inc
                    present = true; //to check of a word is presnt in sent
                }
            }
            else
            {
                present = false;
            }
        }
        return count;
    }

    public static string Longest(string str)
    {
        string curr = "";
        string longest = "";
        for (int i = 0; i < str.Length; i++)
        {
            char ch = (i < str.Length) ? str[i] : ' '; //to get a word
            if (ch != ' ' && ch != '.' && ch != ',' && ch != '!' && ch != '?')
            { //only letters added
                curr += ch;
            }
            else
            {
                if (curr.Length > longest.Length)
                    longest = curr;

                curr = ""; //word is complete
            }
        }

        return longest;
    }

    public static string Replace(string str, string old, string neww)
    {
        string res = "";
        string curr = "";

        for (int i = 0; i < str.Length; i++)
        {
            char ch = (i < str.Length) ? str[i] : ' '; //for reaching the last char of the word

            if (ch != ' ' && ch != '.' && ch != ',' && ch != '!' && ch != '?')
            {
                curr += ch;
            } //word complete ->else statement
            else
            {
                if (curr.Length > 0)
                {
                    if (IgnoreCase(curr, old))
                    {
                        res += neww;  //replace with new word
                    }
                    else
                    {
                        res += curr;
                    }
                    curr = ""; //reset for another word
                }
                res += ch;
            }
        }
        return res;

    }

    static bool IgnoreCase(string str, string strr)
    {
        if (str.Length != strr.Length)
        {
            return false;
        }
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            char sh = strr[i];

            if (ch >= 'A' && ch <= 'Z')
            { //both two lower case to compare
                ch = (char)(ch + 32);
            }

            if (sh >= 'A' && sh <= 'Z')
            {
                sh = (char)(sh + 32);
            }
            if (ch != sh)
            {
                return false;
            }

        }
        return true;
    }
    public static void Main()
    {
        int input;
        do
        {
            Console.WriteLine("\n===== TEXT UTILITY MENU =====");
            Console.WriteLine("1. Sentence Formatter");
            Console.WriteLine("2. Paragraph Analyzer");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Enter paragraph:");
                    string str = Console.ReadLine();

                    Console.WriteLine("Formatted Paragraph:");
                    Console.WriteLine(Format(str));
                    break;

                case 2:
                    Console.WriteLine("Enter paragraph:");
                    string para = Console.ReadLine();

                    Console.WriteLine("Enter word to replace:");
                    string old = Console.ReadLine();

                    Console.WriteLine("Enter replacement word:");
                    string neww = Console.ReadLine();

                    Console.WriteLine("\nWord Count: " + Count(para));
                    Console.WriteLine("Longest Word: " + Longest(para));
                    Console.WriteLine("Updated Paragraph:");
                    Console.WriteLine(Replace(para, old, neww));
                    break;

                case 3:
                    Console.WriteLine("Exiting");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (input != 3);
    }

}




