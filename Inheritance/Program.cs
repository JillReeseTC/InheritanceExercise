using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> critterList = new List<Animal>();

            Bird parrot = new Bird()
            {
                MovementType = "flies",
                Legs = 2,
                SkinType = "feathers",
                HasWings = true
            };

            critterList.Add(parrot);

            Bird penguin = new Bird()
            {
                MovementType = "swims",
                Legs = 2,
                SkinType = "feathers",
                HasWings = true
            };

            critterList.Add(penguin);

            Reptile newt = new Reptile();

            critterList.Add(newt);

            Reptile snake = new Reptile()
            {
                MovementType = "slithers",
                Legs = 0,
                SkinType = "scales",
                LivesInWater = false
            };

            critterList.Add(snake);

            foreach (var creature in critterList)
            {
                Console.WriteLine($"A {creature} {creature.MovementType} ");
            }
            






        }
    }
}
