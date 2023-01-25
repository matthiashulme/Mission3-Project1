using System;

namespace Mission_3___Project_1
{
    class Support
    {
        //Board Print method. Takes the updated board from the program and prints it out in the normal tik tack toe shape
        public void boardPrint(string[] array)
        {
        Console.WriteLine(array[0] + "|" + array[1] + "|" + array[2] + "\n" +
        "-|-|-\n" +
        array[3] + "|" + array[4] + "|" + array[5] + "\n" +
        "-|-|-\n" +
        array[6] + "|" + array[7] + "|" + array[8]);
        }
        // Decision making method, where it looks at the board and determines what to do next
        public int boardWinner(string[] array)
        {
        // winningCombinations is pretty much every way in which a player can win
        string[] winningCombinations =
        {
            array[0] + array[1] + array[2],
            array[3] + array[4] + array[5],
            array[6] + array[7] + array[8],
            array[0] + array[3] + array[6],
            array[1] + array[4] + array[7],
            array[2] + array[5] + array[8],
            array[0] + array[4] + array[8],
            array[2] + array[4] + array[6]
        };
        // this loop is to find if a player has one of the winning combinations
        for (int i = 0; i < winningCombinations.Length; i++)
        {
            // if x wins then give a 1 for player 1 winner
            if (winningCombinations[i].Equals("XXX"))
            {
            return 1;
            }
            // if o wins then give a 2 for player 2 to win
            else if (winningCombinations[i].Equals("OOO"))
            {
            return 2;
            }
        }
        if (array[0].Equals("1")
            ||
            array[1].Equals("2")
            ||
            array[2].Equals("3")
            ||
            array[3].Equals("4")
            ||
            array[4].Equals("5")
            ||
            array[5].Equals("6")
            ||
            array[6].Equals("7")
            ||
            array[7].Equals("8")
            ||
            array[8].Equals("9"))
            {
                return 0;
            }
        
            else
            {
                return 3;
            }
        }
    }
}