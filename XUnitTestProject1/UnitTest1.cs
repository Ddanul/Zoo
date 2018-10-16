using System;
using Xunit;
using Zoo.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ElephantReturnsCall()
        {
            //Arrange
            Elephant e1 = new Elephant()
            {
                Name = "Dan"
            };

            //Assert
            Assert.Equal("*Trumpet call*", e1.MakeNoise());
        }

        [Fact]
        public void ElephantCanSwim()
        {
            //Arrange
            Elephant e2 = new Elephant()
            {
                Name = "Don"
            };

            //Assert
            Assert.Equal("Just keep swimming, just keep swimming...", e2.Swim());
        }

        [Fact]
        public void PlatypusCanLayEgg()
        {
            //Arrange
            Platypus p1 = new Platypus()
            {
                Name = "Silvia Plat"
            };

            //Assert
            Assert.Equal("Plop goes the egg!", p1.LayEgg());
        }

        [Fact]
        public void PlatypusHasBill()
        {
            //Arrange
            Platypus p2 = new Platypus()
            {
                Name = "Shirley"
            };

            //Assert
            Assert.Equal("duck bill", p2.billType);
        }

        [Fact]
        public void TurtleCanSwim()
        {
            //Arrange
            Turtle t1 = new Turtle()
            {
                Name = "charlie"
            };

            //Assert
            Assert.Equal("Turtles swim, right?", t1.Swim());
        }

        [Fact]
        public void TurtleHasTwoEyes()
        {
            //Arrange
            Turtle t2 = new Turtle()
            {
                Name = "chuck"
            };

            //Assert
            Assert.Equal(2, t2.NumberOfEyes);
        }

        [Fact]
        public void SnakeHasYellowScales()
        {
            //Arrange
            Snake s1 = new Snake()
            {
                Name = "sssam"
            };

            //Assert
            Assert.Equal("yellow", s1.ScaleColor);
        }

        [Fact]
        public void SnakeHisses()
        {
            //Arrange
            Snake s2 = new Snake()
            {
                Name = "ssstephen"
            };

            //Assert
            Assert.Equal("Hisssss", s2.MakeNoise());
        }

        [Fact]
        public void SalamanderEmitsToxins()
        {
            //Arrange
            Salamander sa1 = new Salamander()
            {
                Name = "gecko"
            };

            //Assert
            Assert.Equal("I am releasing toxins from my skin!And I am a salamander...", sa1.EmitToxin());
        }

        [Fact]
        public void SalamanderBreathesWater()
        {
            //Arrange
            Salamander sa2= new Salamander()
            {
                Name = "chicken"
            };

            //Assert
            Assert.Equal("Croak", sa2.MakeNoise());
        }

        [Fact]
        public void FrogReleasesToxins()
        {
            //Arrange
            Frog f1 = new Frog()
            {
                Name = "Frank"
            };

            //Assert
            Assert.Equal("I am releasing toxins from my skin!", f1.EmitToxin());
        }

        [Fact]
        public void FrogReturnsName()
        {
            //Arrange
            Frog f2 = new Frog()
            {
                Name = "Skip"
            };

            //Assert
            Assert.Equal("Skip", f2.Name);
        }

        [Fact]
        public void FrogIsAnAnimal()
        {
            //Arrange
            Frog f3 = new Frog()
            {
                Name = "Animal"
            };

            //Assert
            Assert.True(f3 is Animalia);
        }
    }
}
