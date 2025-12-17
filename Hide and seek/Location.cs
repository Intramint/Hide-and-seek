using System;
using System.Collections.Generic;
using System.Text;

namespace Hide_and_seek
{
    abstract internal class Location
    {
        public string Name;
        public Location[] Exits;

        public string Description()
        {
            return Name;
        }
        
    }
}
