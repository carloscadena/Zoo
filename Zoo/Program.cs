using System;
using Zoo.Classes;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Beagle beagle = new Beagle();
            Console.WriteLine(beagle.IsHunter);
            Console.WriteLine(beagle.DoTrick());
            Console.WriteLine(beagle.EatFood());
            Console.WriteLine(beagle.FormsGroup());
            Console.WriteLine(beagle.MakesBabies());
            Console.WriteLine(beagle.LearnTrick());

            Husky husky = new Husky();
            Console.WriteLine(husky.LovesSnow);
            Console.WriteLine(husky.DoTrick());
            Console.WriteLine(husky.EatFood());
            Console.WriteLine(husky.FormsGroup());
            Console.WriteLine(husky.MakesBabies());
            Console.WriteLine(husky.LearnTrick());

            Chimpanzee chimp = new Chimpanzee();
            Console.WriteLine(chimp.HasHeart);
            Console.WriteLine(chimp.NumberOfLegs);
            Console.WriteLine(chimp.EatFood());
            Console.WriteLine(chimp.FormsGroup());
            Console.WriteLine(chimp.MakesBabies());
            Console.WriteLine(beagle.MakeSound());

            Dolphin dolphin = new Dolphin();
            Console.WriteLine(dolphin.HasHeart);
            Console.WriteLine(dolphin.BreathesAir);
            Console.WriteLine(dolphin.HasScales);
            Console.WriteLine(dolphin.DoTrick());
            Console.WriteLine(dolphin.EatFood());
            Console.WriteLine(dolphin.EatsHumans());
            Console.WriteLine(dolphin.MakesBabies());
            Console.WriteLine(dolphin.MakeSound());

            Shark shark = new Shark();
            Console.WriteLine(shark.HasHeart);
            Console.WriteLine(shark.BreathesAir);
            Console.WriteLine(shark.HasScales);
            Console.WriteLine(shark.EatFood());
            Console.WriteLine(shark.EatsHumans());
            Console.WriteLine(shark.MakeSound());
        }
          
    }
}
