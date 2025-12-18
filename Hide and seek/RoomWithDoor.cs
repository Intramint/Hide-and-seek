using System;
using System.Collections.Generic;
using System.Text;

namespace Hide_and_seek
{
    public class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription, string hidingPlace) : base(name, decoration, hidingPlace) 
        {
            DoorDescription = doorDescription;
        }

        public string DoorDescription { get; }
        public Location DoorLocation { get; set; }

        public override string Description
        {
            get
            {
                return string.Format("{0} oraz {1} prowadzące do {2}.", base.Description, DoorDescription, DoorLocation.Name);
            }
        }
    }
}
