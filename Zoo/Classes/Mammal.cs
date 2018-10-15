using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Mammal : Animalia
    {
        public bool hasHair { get; set; } = true;

        public abstract string MakeNoise();

        public virtual string DrinkMilk()
        {
            return "I'm a mammal, I drink milk.";
        }
    }
}
