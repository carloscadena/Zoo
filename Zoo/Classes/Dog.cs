using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Dog : Mammals
    {
        public override string HasHeart { get; set; } = "Of course I have a heart";
        public override int NumberOfLegs { get; set; } = 4;
        
        public virtual string LearnTrick()
        {
            return "I can spin in a circle!";
        }
    }
}
