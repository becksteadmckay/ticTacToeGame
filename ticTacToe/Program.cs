using System;
using System.Collections.Generic;

namespace Cse210Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe Game");

            string currentPlayer = "x";

            List<string> squares = GetNewBoard();
            
            for (int i = 0; i < 10; i++){

                displayBoard(squares);

                if (checkWinner(squares) == true){
                    i++;
                }

                getInput(currentPlayer, squares);

                currentPlayer = nextPlayer(currentPlayer);

                if (checkWinner(squares) == true){
                    i = 9;
                }

            }
        }
        static List<string> GetNewBoard()
        {
            List<string> board = new List<string>();

            for (int i = 1; i <= 9; i++)
            {
                board.Add(i.ToString());
            }
            return board;
        }
        static void displayBoard(List<string> squares)
        {
            Console.WriteLine($"-----\n{squares[0]}|{squares[1]}|{squares[2]}");
                Console.WriteLine($"-+-+-\n{squares[3]}|{squares[4]}|{squares[5]}");
                Console.WriteLine($"-+-+-\n{squares[6]}|{squares[7]}|{squares[8]}\n-----");

        }
        static bool checkWinner(List<string> squares)
        {

            bool isWinner = false;

            if (squares[0] == squares[1] && squares[0] == squares[2]
                || squares[3] == squares[4] && squares[3] == squares[5]
                || squares[6] == squares[7] && squares[6] == squares[8]
                || squares[0] == squares[3] && squares[0] == squares[6]
                || squares[1] == squares[4] && squares[1] == squares[7]
                || squares[2] == squares[5] && squares[2] == squares[8]
                || squares[0] == squares[4] && squares[0] == squares[8]
                || squares[6] == squares[4] && squares[6] == squares[2])
            {    
                isWinner = true; 
            }
            return isWinner;
        }
        static void getInput(string player, List<string> squares)
        {
            Console.WriteLine($"Player {player}");
                string playerInput = Console.ReadLine() ?? "";
                int playerInt = int.Parse(playerInput);
                squares[playerInt - 1] = $"{player}";
        }
        static string nextPlayer(string currentPlayer)
        { string nextPlayer = "x";
            if (currentPlayer == "x")
            {
                nextPlayer = "o";
            }
        return nextPlayer;

        }
    }
}  
