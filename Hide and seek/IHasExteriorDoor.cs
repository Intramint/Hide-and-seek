using System;
using System.Collections.Generic;
using System.Text;

namespace Hide_and_seek
{
    internal interface IHasExteriorDoor
    {
        string DoorDescription { get; }
        Location DoorLocation { get; }
    }
}
