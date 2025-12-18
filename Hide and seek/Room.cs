using System;
using System.Collections.Generic;
using System.Text;

namespace Hide_and_seek
{
    public class Room : Location
    {
        public Room (string name, string decoration) : base(name)
        {
            Decoration = decoration;
        }

        public string Decoration { get; }
        public override string Description
        {
            get 
            {
                return base.Description + " Widzisz tutaj " + Decoration;
            }
        }
    }
}
