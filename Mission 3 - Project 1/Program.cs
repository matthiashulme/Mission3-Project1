using System;

namespace Mission_3___Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome
            Console.WriteLine("Welcome to Tik Tak Toe Buddy :) !\n");

            // Create Game Board with stored default numbers and Initialize Player and Done Booleans
            string[] gameBoard = new String[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            bool player1 = true;
            bool done = false;

            Support s = new Support();

            // While Loop for each turn until the game finishes
            while (done == false)
            {
                // Print Game Board
                Console.Write("\n");
                s.boardPrint(gameBoard);

                string pick = "";
                // If Player 1
                if (player1 == true)
                {
                    // Take Guess and Update Game Board
                    Console.Write("\nPlayer 1 pick a slot: ");
                    pick = Console.ReadLine();

                    if (pick == "1")
                    {
                        gameBoard[0] = "X";
                    }
                    else if (pick == "2")
                    {
                        gameBoard[1] = "X";
                    }
                    else if (pick == "3")
                    {
                        gameBoard[2] = "X";
                    }
                    else if (pick == "4")
                    {
                        gameBoard[3] = "X";
                    }
                    else if (pick == "5")
                    {
                        gameBoard[4] = "X";
                    }
                    else if (pick == "6")
                    {
                        gameBoard[5] = "X";
                    }
                    else if (pick == "7")
                    {
                        gameBoard[6] = "X";
                    }
                    else if (pick == "8")
                    {
                        gameBoard[7] = "X";
                    }
                    else if (pick == "9")
                    {
                        gameBoard[8] = "X";
                    }

                    player1 = false;
                }
                // If Player 2
                else
                {
                    // Take Guess and Update Game Board
                    Console.Write("\nPlayer 2 pick a slot: ");
                    pick = Console.ReadLine();

                    if (pick == "1")
                    {
                        gameBoard[0] = "O";
                    }
                    else if (pick == "2")
                    {
                        gameBoard[1] = "O";
                    }
                    else if (pick == "3")
                    {
                        gameBoard[2] = "O";
                    }
                    else if (pick == "4")
                    {
                        gameBoard[3] = "O";
                    }
                    else if (pick == "5")
                    {
                        gameBoard[4] = "O";
                    }
                    else if (pick == "6")
                    {
                        gameBoard[5] = "O";
                    }
                    else if (pick == "7")
                    {
                        gameBoard[6] = "O";
                    }
                    else if (pick == "8")
                    {
                        gameBoard[7] = "O";
                    }
                    else if (pick == "9")
                    {
                        gameBoard[8] = "O";
                    }

                    player1 = true;
                }
                // Call boardWinner Method in Support Class
                int result = s.boardWinner(gameBoard);

                // Display results if Win or Draw
                if (result == 1)
                {
                    Console.Write("\n");
                    s.boardPrint(gameBoard);
                    Console.WriteLine("\nPlayer 1 Wins!");
                    done = true;
                }
                else if (result == 2)
                {
                    Console.Write("\n");
                    s.boardPrint(gameBoard);
                    Console.WriteLine("\nPlayer 2 Wins!");
                    done = true;
                }
                else if (result == 3)
                {
                    Console.Write("\n");
                    s.boardPrint(gameBoard);
                    Console.WriteLine("\nCat's Game!");
                    done = true;
                }
            }
        }
    }
}
