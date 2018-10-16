using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Amphibian : Animalia
    {
        public override string MakeNoise()
        {
            return "Croak";
        }

        public void BreatheWater()
        {
            Console.WriteLine("Blub blub blub, breathing underwater");
        }

        public virtual string EmitToxin()
        {
            return "I am releasing toxins from my skin!";
        }
    }
}
