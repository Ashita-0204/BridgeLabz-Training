using System;
using System.Linq.Expressions;
class EduQuiz
{
    static string[] question = new string[10];
    static string[] correctAns = new string[10];
    static bool validAns = false;
    const string pass = "Vitamin-ki-goli";
    public static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n================= EDUQUIZ-STUDENT QUIZ GRADER -=============");
            Console.WriteLine("1. Teacher Mode");
            Console.WriteLine("2. Student Mode");
            Console.WriteLine("3. Exit");
            Console.Write("Select option: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    if (Secure())
                        TeacherMenu();
                    break;
                case 2:
                    StudentMenu();
                    break;
                case 3:
                    Console.WriteLine("Goodbye");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
        while (choice != 3);
    }
    public static bool Secure()
    {
        Console.Write("Enter password");
        string input = Console.ReadLine();
        if (input == pass)
        {
            Console.WriteLine("Access Granted! ");
            return true;
        }
        else
        {
            Console.WriteLine("Invalid Access");
            return false;
        }
    }

    public static void TeacherMenu()
    {
        Console.WriteLine("Enter Questions and correct answers "); //input for ques/ans
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter Questions : ");
            question[i] = Console.ReadLine();
            Console.WriteLine("Enter Correct Answers : ");
            correctAns[i] = Console.ReadLine();
        }
        validAns = true;
        Console.WriteLine("Question and answers saved successfully ");

    }

    public static void StudentMenu()
    {
        if (!validAns)
        {
            Console.WriteLine("Question and answers are not present ");
            return;
        }
        Console.WriteLine("\n--- STUDENT QUIZ ---");
        string[] studentAns = new string[10];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(question[i]);
            Console.Write("Your Answer : ");
            studentAns[i] = Console.ReadLine();
        }
        int score = CalculateScore(correctAns, studentAns); //calculation of fscores

        double percentage = (score / 10) * 100;
        Console.WriteLine("\n----- RESULT -----");
        Console.WriteLine("Score: " + score + "/10");
        Console.WriteLine("Percentage: " + percentage + "%");
        if (percentage >= 60)
            Console.WriteLine("Status: PASS");
        else
            Console.WriteLine("Status: FAIL");
    }

    static int CalculateScore(string[] correctAns, string[] studentAns)
    {
        int score = 0;

        Console.WriteLine("\n--- FEEDBACK ---");

        for (int i = 0; i < correctAns.Length; i++)
        {
            bool isCorrect = correctAns[i].Equals(studentAns[i], StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(question[i]);
            if (isCorrect)
            {
                Console.WriteLine("Question : Correct");
                score++;
            }
            else
            {
                Console.WriteLine("Question : Incorrect");
            }
        }

        return score;
    }
}