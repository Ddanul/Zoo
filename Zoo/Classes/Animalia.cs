using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Animalia
    {
        public abstract string Name { get; set; }
        public virtual int NumberOfEyes { get; set; } = 2;

        public abstract string MakeNoise();
    }
}
