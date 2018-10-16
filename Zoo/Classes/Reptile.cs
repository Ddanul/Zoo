using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Reptile : Animalia
    {
        public virtual string ScaleColor { get; set; } = "Green";

        public override string MakeNoise()
        {
            return "Hisssss";
        }
    }
}
