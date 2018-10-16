using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Placental : Mammal
    {
        public virtual string HasTail()
        {
            return "My tail sways.";
        }
    }
}
