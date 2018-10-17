using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Shark : Fish
    {
        public override string HasHeart { get; set; } = "Of course I have a heart";
        public override bool HasScales { get; set; } = false;
        public override string BreathesAir { get; set; } = "That would kill me!";

        public override string EatsHumans()
        {
            return "Humans are a delicacy";
        }
        public override string EatFood()
        {
            return "In addition to humans, I also like smaller fish.";
        }
    }
}
