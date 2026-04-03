using System;
using System.Diagnostics.CodeAnalysis;
class SnakeLadder
{
    static int[] pos = new int[4];
    static string[] names = new string[4];
    static int players = 0;
    static int[] LadderStart = { 4, 9, 20, 28, 40, 17, 54, 62, 64, 98 };
    static int[] LadderEnd = { 14, 31, 38, 84, 59, 7, 34, 19, 60, 79 };
    static Random random = new Random();

    static void SetupPlayers()
    {
        Console.Write("Enter number of players");
        players = int.Parse(Console.ReadLine());
        if (players < 1 || players > 4) //Min num of players to take part
        {
            Console.WriteLine("Invalid Count");
            players = 1;
        }
        for (int i = 0; i < players; i++)
        {
            pos[i] = 0; //reset the positions to 0
            names[i] = "Player " + (i + 1);
        }

        Console.WriteLine("\nPlayers Ready!");
    }


    static void PlayGame()
    {
        bool win = false;

        Console.WriteLine(" Game Started! \n");

        while (!win)
        {
            for (int i = 0; i < players; i++)
            {
                Console.WriteLine("\n" + names[i] + " 's turn");
                Console.ReadLine();

                int dice = random.Next(1, 7); //random num for dice
                Console.WriteLine(names[i] + " rolled: " + dice);

                int oldPos = pos[i];
                int newPos = oldPos + dice; //increment acc to the dice 

                if (newPos > 100)
                {
                    Console.WriteLine("Move exceeds 100 - turn skipped");
                    continue;
                }

                pos[i] = newPos;

                ApplySnakeLadder(i);

                Console.WriteLine(" Position: " + oldPos + " moves to " + pos[i]);

                if (pos[i] == 100) //when reached 100 
                {
                    Console.WriteLine(names[i] + "WINS THE GAME!");
                    win = true;
                    break;
                }
            }
        }
    }

    static void ApplySnakeLadder(int i)
    {
        int currentPos = pos[i]; // get the current pos

        for (int j = 0; j < LadderStart.Length; j++) //snake/ladder arr
        {
            if (currentPos == LadderStart[j])
            {
                bool isLadder = LadderEnd[j] > currentPos;  //if(ladder then inc) else snake
                Console.WriteLine(isLadder ? " Ladder Up!" : " Snake Down!");
                pos[i] = LadderEnd[j];
                return;
            }
        }
    }

    public static void Main()
    {
        int input;

        do
        {
            Console.WriteLine("=== SNAKE & LADDER ===");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Exit");
            Console.Write("Enter choice: ");
            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    SetupPlayers();
                    PlayGame();
                    break;
                case 2:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (input != 2);
    }

}