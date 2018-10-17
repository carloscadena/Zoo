using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Husky : Dog
    {
        public string LovesSnow { get; set; } = "I was made for the snow!";

        public override string EatFood()
        {
            return "I'm always hungry";
        }

        public override string FormsGroup()
        {
            return "I yearn to be a part of a pack";
        }

        public override string MakesBabies()
        {
            return "I enjoy the process of making babies";
        }
        public override string LearnTrick()
        {
            return "I can speak now! Bark Bark!";
        }
        public override string DoTrick()
        {
            return "*rolls over*";
        }
    }
}
