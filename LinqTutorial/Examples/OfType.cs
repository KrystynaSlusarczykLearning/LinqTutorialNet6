using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace LinqTutorial
{
    static class OfType
    {
        //System.Linq.Enumerable.OfType
        public static void Run()
        {
            //OfType returns all the objects of given type
            var objects = new object[]
            {
                null,
                1,
                "all",
                2,
                "ducks",
                new List<int>(),
                "are",
                "awesome",
                true
            };

            var strings = objects.OfType<string>();
            Printer.Print(strings, nameof(strings));

            //it's often used when operating on multiple types with one interface
            var flyables = new List<IFlyable>()
            {
                new Bird(),
                new Plane(),
                new Helicopter()
            };

            var birds = flyables.OfType<Bird>();
            Printer.Print(birds, nameof(birds));

            var fuelables = flyables.OfType<IFuelable>();
            Printer.Print(fuelables, nameof(fuelables));
        }
    }

    interface IFlyable
    {
        public void Fly();
    }

    interface IFuelable
    {
        public void Fuel();
    }

    class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Flying by flapping my wings");
        }
    }

    class Plane : IFlyable, IFuelable
    {
        public void Fly()
        {
            Console.WriteLine("Flying by jet propulsion");
        }

        public void Fuel()
        {
            Console.WriteLine("Fuelling my large gas tank");
        }
    }

    class Helicopter : IFlyable, IFuelable
    {
        public void Fly()
        {
            Console.WriteLine("Flying by rotating my rotors");
        }

        public void Fuel()
        {
            Console.WriteLine("Fuelling my gas tank");
        }
    }
}
