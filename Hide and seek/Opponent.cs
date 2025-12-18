using System;
using System.Collections.Generic;
using System.Text;

namespace Hide_and_seek
{
    public class Opponent
    {
        public Opponent(Location startingPosition, Random random)
        {
            myLocation = startingPosition;
            this.random = random;
        }

        public Location myLocation;
        private Random random;

        public void Move()
        {
            int roll = random.Next(2);
            if (myLocation is IHasExteriorDoor)
            {
                if (roll == 1)
                { //go through door
                    IHasExteriorDoor locationWithDoor = myLocation as IHasExteriorDoor;
                    myLocation = locationWithDoor.DoorLocation;
                    return;
                }
                
            }
            roll = random.Next(myLocation.Exits.Length);
            myLocation = myLocation.Exits[roll];
        }
    }
}
