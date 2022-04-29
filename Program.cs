using System;


namespace Cse210Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Write your code here

            char[] squares = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};
            int[] turn = {1,2,1,2,1,2,1,2,1,};
            
            for (int i = 0; i < turn.Length; i++){

                Console.WriteLine($"-----\n{squares[0]}|{squares[1]}|{squares[2]}");
                Console.WriteLine($"-+-+-\n{squares[3]}|{squares[4]}|{squares[5]}");
                Console.WriteLine($"-+-+-\n{squares[6]}|{squares[7]}|{squares[8]}\n-----");

                if (squares[0] == squares[1] && squares[0] == squares[2]
                || squares[3] == squares[4] && squares[3] == squares[5]
                || squares[6] == squares[7] && squares[6] == squares[8]
                || squares[0] == squares[3] && squares[0] == squares[6]
                || squares[1] == squares[4] && squares[1] == squares[7]
                || squares[2] == squares[5] && squares[2] == squares[8]
                || squares[0] == squares[4] && squares[0] == squares[8]
                || squares[6] == squares[4] && squares[6] == squares[2]){
                    i = turn.Length;
                } 
                else {
                    if (turn[i] - 1 == 0){
                        Console.WriteLine("Player 1");
                        string player1Input = Console.ReadLine();
                        int player1 = int.Parse(player1Input);
                        squares[player1 - 1] = 'x';}

                    else if(turn[i] - 1 == 1){
                        Console.WriteLine("Player 2");
                        string player2Input = Console.ReadLine();
                        int player2 = int.Parse(player2Input);
                        squares[player2 - 1] = 'o';}
                }
                
                Console.WriteLine(squares);

            }
        }
    }   
} 
