using System;
using System.Collections.Generic;
using System.Text;

namespace Hide_and_seek
{
    abstract class Location
    {
        public Location(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
        public Location[] Exits;

        public virtual string Description
        {
            get
            {
                string description = string.Format("Stoisz w: {0}. Widzisz wyjście do nasttępujących lokalizacji: ", Name);
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i < Exits.Length - 1)
                        description += ", ";
                }
                description += ".";
                return description;
            }
        }
        
    }
}
