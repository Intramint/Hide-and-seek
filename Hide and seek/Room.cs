using System;
using System.Collections.Generic;
using System.Text;

namespace Hide_and_seek
{
    public class Room : Location
    {
        public Room (string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }

        private string decoration;
        public override string Description
        {
            get 
            {
                return base.Description + " Widzisz tutaj " + decoration;
            }
        }
    }
}
