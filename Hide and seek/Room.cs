using System;
using System.Collections.Generic;
using System.Text;

namespace Hide_and_seek
{
    internal class Room : Location
    {
        public Room (string name, string decoration) : base(name)
        {
            Decoration = decoration;
        }

        public string Decoration { get; }
    }
}
