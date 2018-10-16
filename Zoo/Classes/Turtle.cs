using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Turtle : Reptile, ILayEggs, ISwim
    {
        public override string Name { get; set; }

        public string LayEgg()
        {
            return "Ploppity plop goes the turtle egg";
        }

        public string Swim()
        {
            return "Turtles swim, right?"; 
        }
    }
}
