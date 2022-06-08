using System;
using System.Collections.Generic;


namespace Unit03.Game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private Hider hider = new Hider();
        private bool isPlaying = true;
        private Seeker seeker = new Seeker();

        private Chute chute = new Chute();
        private TerminalService terminalService = new TerminalService();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Moves the seeker to a new location.
        /// </summary>
        private void GetInputs()
        {
            
            char guess = terminalService.ReadChar("\nEnter any letter. ");
            seeker.MoveLocation(guess);
            hider.checkGuess(guess);
        }

        /// <summary>
        /// Keeps watch on where the seeker is moving.
        /// </summary>
        private void DoUpdates()
        {
            hider.WatchSeeker(seeker);
            chute.WatchHider_true(hider);
            hider.checkWord(hider);
            

        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {
            terminalService.WriteText(chute.GetChute());
            string hint = hider.GetHint();
            terminalService.WriteText(hint);
            if (chute.returnCount() > 6)
            {
                isPlaying = false;
            }
            
        }
    }
}