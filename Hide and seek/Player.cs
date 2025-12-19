using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hide_and_seek
{
    public class Player
    {
        public Player(Location startingLocation) {
            CurrentLocation = startingLocation;
        }


        public int ActionCounter { get; private set; } = 0;
        public Location CurrentLocation { get; private set; }


        public bool SearchCurrentRoom(Opponent opponent)
        {
            ActionCounter++;

            if (opponent.hiddenHere(CurrentLocation))
                return true;
            return false;
        }


        public void MoveTo(Location newLocation)
        {
            ActionCounter++;
            CurrentLocation = newLocation;
        }

        
    }
}
