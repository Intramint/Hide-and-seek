using System;
using System.Collections.Generic;
using System.Text;

namespace Hide_and_seek
{
    public class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool isHot, string hidingPlace) : base(name, isHot)
        {
            HidingPlace = hidingPlace;
        }
        public string HidingPlace { get; }
    }
}
