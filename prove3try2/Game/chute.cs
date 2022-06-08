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
    public class Chute
    {
        private TerminalService terminalService = new TerminalService();
        private List<string> _lines = new List<string>();
        private int _count = 0;

        /// <summary>
        /// Constructs a new instance of Hider. 
        /// </summary>
        public Chute()
        {
            MakeChute();
            // start with two so GetHint always works
        }

        public void MakeChute()
        {
            _lines.Add(@"  ___  ");
            _lines.Add(@"/// \\\");
            _lines.Add(@"||| |||");
            _lines.Add(@"\\\ ///");
            _lines.Add(@" \\ // ");
            _lines.Add(@"  \ /  ");
            _lines.Add(@"   |   ");
        }
        // public void cutString()
        // {
        //     for (int i = 0; i < _count; i ++)
        //     {
        //         _lines.RemoveAt(0);
        //     }
        // }

        // /// <summary>
        // /// Gets a hint for the seeker.
        // /// </summary>
        // /// <returns>A new hint.</returns>
        // public string GetChute()
        // {
        //     return string.Join("\n", _lines);
        // }
        public string GetChute()
        {
            List<string> newlist = new List<string>();

            if (_count < _lines.Count){

            for( int i = _count; i < _lines.Count; i ++)
            {
               newlist.Add(_lines[i]);
            }
            }
            else
            {
                return "dead";
            }
            return string.Join("\n", newlist);
        }


        /// <summary>
        /// Watches the seeker by keeping track of how far away it is.
        /// </summary>
        /// <param name="seeker">The seeker to watch.</param>
        public void WatchHider_true(Hider hider)
        {
            if (hider._true == false)
            {
                _count += 1;
            }
        }

        public int returnCount()
        {
            return _count;
        }
    }
}