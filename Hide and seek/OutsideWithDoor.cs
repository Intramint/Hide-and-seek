using System;
using System.Collections.Generic;
using System.Text;

namespace Hide_and_seek
{
    internal class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name) : base(name) { }
    }
}
