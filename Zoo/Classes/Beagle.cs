using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Beagle : Dog
    {
        public string isHunter { get; set; } = "I was bred to hunt";
        public override string EatFood()
        {
            return "mmhmm more kibble please";
        }

        public override string FormsGroup()
        {
            return "I yearn to be a part of a pack";
        }

        public override string MakesBabies()
        {
            return "As often as I can";
        }
        public override string LearnTrick()
        {
            return "I can roll over!";
        }
    }
}
