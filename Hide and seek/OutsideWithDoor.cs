using System;
using System.Collections.Generic;
using System.Text;

namespace Hide_and_seek
{
    public class OutsideWithDoor : OutsideWithHidingPlace, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool isHot, string doorDescription, string hidingPlace) : base(name, isHot, hidingPlace) 
        {
            DoorDescription = doorDescription;
        }
            
        public string DoorDescription { get; }
        public Location DoorLocation { get; set; }

        public override string Description
        {
            get
            {
                return string.Format("{0} Są także {1} prowadzące do {2}.", base.Description, DoorDescription, DoorLocation.Name);
            }
        }
    }
}
