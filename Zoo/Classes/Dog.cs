using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public abstract class Dog : Mammals, IDoTricks, ISwim
    {
        public override string HasHeart { get; set; } = "Of course I have a heart";
        public override int NumberOfLegs { get; set; } = 4;

        public virtual string DoTrick()
        {
            return "What trick would you like to see?";
        }

        public virtual string LearnTrick()
        {
            return "I can spin in a circle!";
        }
        public override string MakeSound()
        {
            return "Bow-wow-wow";
        }
        public string Swim()
        {
            return "Fun fact, the doggie paddle was actually named after me.";
        }
    }
}
