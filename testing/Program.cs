using System;
using System.Collections.Generic;

namespace cse210_student_csharp_tictactoe_complete
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> board = GetNewBoard();
            string currentPlayer = "x";
            while (!IsGameOver(board))
            {
                DisplayBoard(board);
                int choice = GetMoveChoice(currentPlayer);
                MakeMove(board, choice, currentPlayer);
                currentPlayer = GetNextPlayer(currentPlayer);
            }
            DisplayBoard(board);
            Console.WriteLine("Good game. Thanks for playing!");
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
        static void DisplayBoard(List<string> board)
        {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
        }
        static bool IsGameOver(List<string> board)
        {
            bool isGameOver = false;
            if (IsWinner(board, "x") || IsWinner(board, "o") || IsTie(board))
            {
                isGameOver = true;
            }
            return isGameOver;
        }
        static bool IsWinner(List<string> board, string player)
        {
            // There are more elegant ways to check for a win, especially if
            // something besides a 3x3 board were anticipated. This brute force
            // approach is sufficient to check for the possibilities.
            bool isWinner = false;
            if ((board[0] == player && board[1] == player && board[2] == player)
                || (board[3] == player && board[4] == player && board[5] == player)
                || (board[6] == player && board[7] == player && board[8] == player)
                || (board[0] == player && board[3] == player && board[6] == player)
                || (board[1] == player && board[4] == player && board[7] == player)
                || (board[2] == player && board[5] == player && board[8] == player)
                || (board[0] == player && board[4] == player && board[8] == player)
                || (board[2] == player && board[4] == player && board[6] == player)
                )
            {
                isWinner = true;
            }
            return isWinner; 
        }
        static bool IsTie(List<string> board)
        {
            
            // If there is a digit, there are still moves to be made.
            bool foundDigit = false;
            foreach (string value in board)
            {
                if (char.IsDigit(value[0]))
                {
                    foundDigit = true;
                    break;
                }
            }
            return !foundDigit;
        }
        static string GetNextPlayer(string currentPlayer)
        {
            string nextPlayer = "x";
            if (currentPlayer == "x")
            {
                nextPlayer = "o";
            }
            return nextPlayer;
        }
        static int GetMoveChoice(string currentPlayer)
        {
            Console.Write($"{currentPlayer}'s turn to choose a square (1-9): ");
            string move_string = Console.ReadLine();
            int choice = int.Parse(move_string);
            return choice;
        }
        static void MakeMove(List<string> board, int choice, string currentPlayer)
        {
            int index = choice - 1;
            board[index] = currentPlayer;
        }


    }
}