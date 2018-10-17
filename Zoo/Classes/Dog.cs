using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Dog : Mammals
    {
        public override string HasHeart { get; set; } = "Of course I have a heart";
        public override int NumberOfLegs { get; set; } = 4;
        
        public override string EatFood()
        {
            return "I will eat whatever my master gives me";
        }

        public override string FormsGroup()
        {
            return "I'd form a group if I was allowed to";
        }

        public override string MakesBabies()
        {
            return "I can't control my urge to make babies!";
        }
    }
}
