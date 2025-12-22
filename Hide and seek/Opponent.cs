using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hide_and_seek
{
    public class Opponent
    {
        public Opponent(Location startingPosition, Random random)
        {
            MyLocation = startingPosition;
            this.random = random;
        }

        public Location MyLocation;
        private Random random;

        public void Move()
        {
            int roll = random.Next(2);
            if (MyLocation is IHasExteriorDoor)
            {
                if (roll == 1)
                { //go through door
                    IHasExteriorDoor locationWithDoor = MyLocation as IHasExteriorDoor;
                    MyLocation = locationWithDoor.DoorLocation;
                    return;
                }
                
            }
            roll = random.Next(MyLocation.Exits.Length);
            MyLocation = MyLocation.Exits[roll];
        }

        public bool hiddenHere(Location location) //there's only one hiding spot max per room, so we don't care about the specific hiding spot, just the room.
        {
            if (MyLocation == location)
                return true;
            return false;
        }
    }
}
