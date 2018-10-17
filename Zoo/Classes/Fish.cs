using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public abstract class Fish : Animals, ISwim
    {
        public virtual bool HasScales { get; set; } = true;

        public virtual string EatsHumans()
        {
            return "Humans are delicious!";
        }
        public override string MakesBabies()
        {
            return "Of course we make babies.";
        }

        public string Swim()
        {
            return "swimming is life";
        }
    }
}
