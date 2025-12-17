using System;
using System.Collections.Generic;
using System.Text;

namespace Hide_and_seek
{
    internal class RoomWithDoor : Room, IHasExteriorDoor
    {
        RoomWithDoor(string name, string decoration) : base(name, decoration) { }
    }
}
