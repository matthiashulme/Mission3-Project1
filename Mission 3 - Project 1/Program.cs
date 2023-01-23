using System;

namespace Mission_3___Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome
            Console.WriteLine("Welcome to Tik Tak Toe Buddy :) !");

            // Create Game Board with stored default numbers and Initialize Player and Done Booleans
            string[] gameBoard = new String[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            bool player1 = true;
            bool done = false;

            Support s = new Support();

            // While Loop for each turn until the game finishes
            while (done == false)
            {
                // Print Game Board
                s.boardPrint(gameBoard);

                int pick = 0;
                // If Player 1
                if (player1 == true)
                {
                    // Take Guess and Update Game Board
                    Console.Write("Player 1 pick a slot: ");
                    pick = Convert.ToInt32(Console.Read());
                    gameBoard[pick - 1] = "X";

                    player1 = false;
                }
                // If Player 2
                else
                {
                    // Take Guess and Update Game Board
                    Console.Write("Player 2 pick a slot: ");
                    pick = Convert.ToInt32(Console.Read());
                    gameBoard[pick - 1] = "O";

                    player1 = true;
                }
                // Call boardWinner Method in Support Class
                int result = s.boardWinner(gameBoard);

                // Display results if Win or Draw
                if (result == 1)
                {
                    Console.WriteLine("Player 1 Wins!");
                    done = true;
                }
                else if (result == 2)
                {
                    Console.WriteLine("Player 2 Wins!");
                    done = true;
                }
                else if (result == 3)
                {
                    Console.WriteLine("Cat's Game!");
                    done = true;
                }
            }
        }
    }
}
