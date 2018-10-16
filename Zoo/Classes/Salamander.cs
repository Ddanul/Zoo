using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Salamander : Amphibian
    {
        public override string Name { get; set; }

        public override string EmitToxin()
        {
            return base.EmitToxin() + "And I am a salamander...";
        }
    }
}
