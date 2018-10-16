using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Frog : Amphibian, ILayEggs
    {
        public override string Name { get; set; }

        public string LayEgg()
        {
            return "Ribbit plop plop goes the frog egg";
        }
    }
}
