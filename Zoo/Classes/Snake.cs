using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Snake : Reptile, ILayEggs
    {
        public override string Name { get; set; }

        public override string ScaleColor { get; set; } = "yellow";

        public string LayEgg()
        {
            return "Slither plop goes the snake egg.";
        }
    }
}
