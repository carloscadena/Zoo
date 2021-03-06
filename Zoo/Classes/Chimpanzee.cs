﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Chimpanzee : Mammals
    {
        public override string HasHeart { get; set; } = "Of course I have a heart";
        public override int NumberOfLegs { get; set; } = 2;
        
        public override string EatFood()
        {
            return "I enjoy bananas very much";
        }

        public override string FormsGroup()
        {
            return "Me and my friends make a troupe!";
        }

        public override string MakesBabies()
        {
            return "Making babies is my favorite thing to do";
        }
        public override string MakeSound()
        {
            return "Screech! That's what a chimp sounds like, right?";
        }
    }
}
