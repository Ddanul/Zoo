using System;
using Zoo.Classes;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MammalCalls();
            ReptileCalls();
            AmphibianCalls();
        }

        static void MammalCalls()
        {
            Elephant dumbo = new Elephant()
            {
                Name = "Dumbo"
            };

            Platypus ducky = new Platypus()
            {
                Name = "Ducky"
            };

            Console.WriteLine($"{dumbo.Name} sounds like this : {dumbo.MakeNoise()} and has {dumbo.NumberOfEyes} eyes");
            Console.WriteLine($" platypus does this: {ducky.LayEgg()}");
            ducky.ProduceVenom();
        }

        static void ReptileCalls()
        {
            Turtle donatello = new Turtle()
            {
                Name = "Donatello"
            };

            Snake bob = new Snake()
            {
                Name = "Bob"
            };

            Console.WriteLine($"This turtle has {donatello.ScaleColor} scales");
            donatello.Swim();

            bob.LayEgg();

        }

        static void AmphibianCalls()
        {
            Salamander newt = new Salamander()
            {
                Name = "Newton"
            };

            Frog toad = new Frog()
            {
                Name = "Toad"
            };

            Console.WriteLine($"Careful with the salamander: {newt.EmitToxin()}");
            Console.WriteLine($"The frog goes like this: toad.LayEgg()");
        }
    }
}
