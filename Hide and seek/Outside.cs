using System;
using System.Collections.Generic;
using System.Text;

namespace Hide_and_seek
{
    internal class Outside : Location
    {
        public Outside (string name, bool isHot) : base (name)
        {
            this.isHot = isHot;
        }
        private bool isHot { get; } 
        public override string Description
        {
            get
            {
                if (isHot)
                    return base.Description + " Tutaj jest bardzo gorąco.";
                return base.Description;
            }
        }
    }
}
