using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Platypus : Monotreme, ILayEggs
    {
        public override string FurType { get; set; } = "dense";
        public override string Name { get; set; }

        public string LayEgg()
        {
            return "Plop goes the egg!";
        }

        public override string MakeNoise()
        {
            return "*platypus clicking noise*";
        }

        public override void ProduceVenom()
        {
            Console.WriteLine("You just got toe-stabbed with poison!");
        }
    }
}
