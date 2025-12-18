using System;
using System.Collections.Generic;
using System.Text;

namespace Hide_and_seek
{
    public class RoomWithDoor : Room, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription) : base(name, decoration) 
        {
            DoorDescription = doorDescription;
        }

        public string DoorDescription { get; }
        public Location DoorLocation { get; set; }
    }
}
