using System;
using System.Collections.Generic;
using Unit03.Game;


namespace Unit03.Game
{
    // TODO: Implement the Seeker class as follows...
    public class Seeker
    {
        private char guess;
        public Seeker(){}

        public char GetGuess()
        {
            return guess;
        }
        public char MoveLocation(char newGuess)
        {
            guess = newGuess;
            return guess;
        }

    }
}