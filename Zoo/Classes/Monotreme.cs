using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Monotreme : Mammal
    {
        public virtual string billType { get; set; } = "duck bill";
        
        public abstract void ProduceVenom();
          
    }
}
