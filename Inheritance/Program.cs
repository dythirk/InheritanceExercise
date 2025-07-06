using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird bird1 = new Bird();
            bird1.Name = "Tweety";
            bird1.NumberOfLegs = 2;
            bird1.Size = "Small";
            bird1.MakesSound = "Puddy-tat";
            bird1.IsCarnivore = false;
            bird1.CanHover = false;
            bird1.IsBirdOfPrey = false;
            bird1.IsScavenger = false;
            bird1.IsAquatic = false;

            Console.WriteLine($"This bird is named {bird1.Name}. It has {bird1.NumberOfLegs} legs, and is {bird1.Size}.");
            Console.WriteLine($"The sound {bird1.Name} makes the most is {bird1.MakesSound}. Can it hover? {bird1.CanHover}. \r\n" +
                $"Is it a Carnivore? {bird1.IsCarnivore}.\n\nI bet {bird1.Name} is a Bird of Prey, is this correct? {bird1.IsBirdOfPrey} \r\n" +
                $"What about being Aquatic? {bird1.IsAquatic}\nLastly, is {bird1.Name} a scavenger? {bird1.IsScavenger}");

            Reptile rep1 = new Reptile();

            rep1.Name = "Snakey";
            rep1.NumberOfLegs = 2;
            rep1.Size = "Small";
            rep1.MakesSound = "Puddy-tat";
            rep1.IsCarnivore = false;
            rep1.NumberOfLegs = 0;
            rep1.ArePupilsVertical = false;
            rep1.CanBeDomesticated = false;
            rep1.IsVenomous = false;
            rep1.LaysEggs = false;

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
