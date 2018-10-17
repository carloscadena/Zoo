using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammals : Animals
    {
        public abstract int NumberOfLegs { get; set; }
        public override string BreathesAir { get; set; } = "I love fresh air!";

        public abstract string FormsGroup();
    }
}
