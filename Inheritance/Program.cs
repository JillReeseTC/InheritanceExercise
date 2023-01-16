using System;
using System.Collections.Generic;
using System.Linq;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> critterList = new List<Animal>();

            Bird parrot = new Bird()
            {
                Name = "parrot",
                MovementType = "flies",
                Legs = 2,
                SkinType = "feathers",
                HasWings = true
            };

            critterList.Add(parrot);

            Bird penguin = new Bird()
            {
                Name = "penguin",
                MovementType = "swims",
                Legs = 2,
                SkinType = "feathers",
                HasWings = true
            };

            critterList.Add(penguin);

            Reptile newt = new Reptile();
            newt.Name = "newt";

            critterList.Add(newt);

            Reptile snake = new Reptile()
            {
                Name = "snake",
                MovementType = "slithers",
                Legs = 0,
                SkinType = "scales",
                LivesInWater = false
            };

            critterList.Add(snake);

            //All are added to the list. Now let's unpack it.

            foreach (var animal1 in critterList.OfType<Bird>()) { 

                Console.WriteLine($"{animal1.Name} {animal1.MovementType} has {animal1.Legs} legs, {animal1.SkinType} on its skin");
                if (animal1.HasWings)   
                {
                    Console.WriteLine($"{animal1.Name} has wings!");
                }
                else
                {
                    Console.WriteLine($"{animal1.Name} does not have wings!");
                }
                Console.WriteLine($"{animal1.Name}:");
                if (animal1.MovesIndependently) { Console.WriteLine("Moves independently."); }
                if (animal1.HasParents) { Console.WriteLine("Has parents."); }
                if (animal1.CanHunt) { Console.WriteLine("Can hunt."); }
                if (animal1.CanSee) { Console.WriteLine("Can see."); }
                Console.WriteLine();

            }

            foreach (var animal1 in critterList.OfType<Reptile>())
            {

                Console.WriteLine($"{animal1.Name} {animal1.MovementType} has {animal1.Legs} legs, {animal1.SkinType} on its skin");
                if (animal1.LivesInWater)
                {
                    Console.WriteLine($"{animal1.Name} lives in the water!");
                }
                else
                {
                    Console.WriteLine($"{animal1.Name} does not live in the water!");
                }

                if (animal1.HasParents)
                {
                    Console.WriteLine($"{animal1.Name} has parents.");
                }
                else
                {
                    Console.WriteLine($"{animal1.Name} does not have parents.");
                }
                Console.WriteLine($"{animal1.Name}:");
                if (animal1.MovesIndependently) { Console.WriteLine("Moves independently."); }
                if (animal1.HasParents) { Console.WriteLine("Has parents."); }
                if (animal1.CanHunt) { Console.WriteLine("Can hunt."); }
                if (animal1.CanSee) { Console.WriteLine("Can see."); }

                Console.WriteLine();

            }


            //foreach (var creature in critterList)
            //{
             //   var critterType = creature.GetType().Name;
             //   Console.WriteLine($"{creature} is {critterType}");
            //}

        }
    }
}
