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
    }
}
