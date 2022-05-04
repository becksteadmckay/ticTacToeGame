// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static List<string> starterBoard()
            {
                List<string> board = new List<string>();

                for (int i = 0; i < 9; i++){

                    board.Add(i.ToString());

                }
                return board;
            }
            Console.Write(starterBoard());

              

        }
    }
}