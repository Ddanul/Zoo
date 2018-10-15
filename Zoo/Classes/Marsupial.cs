using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Marsupial : Mammal
    {
        public bool hasPouch { get; set; } = true;

        public override string MakeNoise()
        {
            return "There's a snake in ma pouch!";
        }
    }
}
