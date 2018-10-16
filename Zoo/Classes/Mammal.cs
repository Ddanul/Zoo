using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammal : Animalia
    {
        abstract public string FurType { get; set; }

        public void BreatheAir()
        {
            Console.WriteLine("I love breathing fresh air!");
        }
    }
}
