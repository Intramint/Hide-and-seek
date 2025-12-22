using System;
using System.Collections.Generic;
using System.Text;

namespace Hide_and_seek
{
    public class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string decoration, string hidingPlace) : base(name, decoration)
        {
            HidingPlace = hidingPlace;
        }
        public string HidingPlace {  get; }
    }
}
