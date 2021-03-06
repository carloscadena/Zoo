﻿using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Dolphin : Fish, IDoTricks
    {
        public override string HasHeart { get; set; } = "Of course I have a heart.";
        public override string BreathesAir { get; set; } = "I do breathe air! and now I'm realizing that I should have been in the mammal class..";
        public override bool HasScales { get; set; } = false;

        public string DoTrick()
        {
            return "*jumps out of water and flips*";
        }

        public override string EatFood()
        {
            return "Thanks for all the fish!";
        }
        public override string EatsHumans()
        {
            return "Humans are my friend!";
        }
        public override string MakesBabies()
        {
            return "Making babies is the most fun I have.";
        }
        public override string MakeSound()
        {
            return "squeak squeak";
        }
    }
}
