using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Animals
    {
        public abstract string HasHeart { get; set; }
        public virtual string BreathesAir { get; set; }

        public abstract string MakesBabies();
        public abstract string EatFood();
        public virtual string MakeSound()
        {
            return "Moo";
        }
    }
}
