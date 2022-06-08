using System;
using System.Collections.Generic;


namespace Unit03.Game
{
    /// <summary>
    /// <para>The person hiding from the Seeker.</para>
    /// <para>
    /// The responsibility of Hider is to keep track of its location and distance from the seeker.
    /// </para>
    /// </summary>
    public class Hider
    {
        public string _word;

        
        
        public bool _true;
        private List<char> _guesses = new List<char>();

        /// <summary>
        /// Constructs a new instance of Hider. 
        /// </summary>
        public Hider()
        {
            _word = "apple";
            // start with two so GetHint always works
        }

        /// <summary>
        /// Gets a hint for the seeker.
        /// </summary>
        /// <returns>A new hint.</returns>
        public string GetHint()
        {
            string hint = "";
            foreach (var letter in _word)
            {
                if (_guesses.Contains(letter))
                {
                    hint += $"{letter}";
                }
                else
                {
                    hint += "_";
                }

            }
            return hint;
        }
s
        // public string checkWord(Hider hider)
        // {
        //     if (hider.GetHint() == hider._word)
        //     {
        //         return "Found Word!";
        //     }
        //     else
        //     {
        //         return "not found";
        //     }
        // }

        /// <summary>
        /// Whether or not the hider has been found.
        /// </summary>
        /// <returns>True if found; false if otherwise.</returns>
        public void checkGuess(char guess)
        {
            if (_word.Contains(guess))
            {
                _true = true;
            }
            else
            {
                _true = false;
            }
        }

        /// <summary>
        /// Watches the seeker by keeping track of how far away it is.
        /// </summary>
        /// <param name="seeker">The seeker to watch.</param>
        public void WatchSeeker(Seeker seeker)
        {
            _guesses.Add(seeker.GetGuess());
        }
    }
}