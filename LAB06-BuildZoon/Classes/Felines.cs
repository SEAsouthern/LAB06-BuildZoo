using System;
using System.Collections.Generic;
using System.Text;

namespace LAB06_BuildZoo.Classes
{
    abstract class Felines : Mammals
    {
        public bool HasStripes { get; set; }
        public bool IsSolitary { get; set; }
    }
}
