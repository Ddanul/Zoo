using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Elephant : Placental, ISwim
    {
        public override string FurType { get; set; } = "short";
        public override string Name { get; set; }

        public override string MakeNoise()
        {
            return "*Trumpet call*";
        }

        public string Swim()
        {
            return "Just keep swimming, just keep swimming...";
        }
    }
}
