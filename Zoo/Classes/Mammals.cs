using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammals : Animals
    {
        public int NumberOfLegs { get; set; }

        public abstract string FormsGroup()
        {
            return "I assemble into a flock!";
        }
    }
}
