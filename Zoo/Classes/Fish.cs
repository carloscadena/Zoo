using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Fish : Animals
    {
        public bool HasScales { get; set; }

        public virtual string EatsHumans()
        {
            return "Humans are delicious!";
        }
        public override string MakesBabies()
        {
            return "Of course we make babies.";
        }
        public override string EatFood()
        {
            return "I like to eat fish that are smaller than me.";
        }

    }
}
