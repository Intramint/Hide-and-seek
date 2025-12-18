using System;
using System.Collections.Generic;
using System.Text;

namespace Hide_and_seek
{
    internal class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool isHot, string doorDescription) : base(name, isHot) 
        {
            DoorDescription = doorDescription;
        }

        public string DoorDescription { get; }
        public Location DoorLocation { get; set; }
    }
}
