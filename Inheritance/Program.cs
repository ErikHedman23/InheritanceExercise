using System;
using System.Drawing;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            var bird = new Bird();
            bird.Species = "Cardinal";
            bird.CanBeAPet = true;
            bird.DietConsists = "small insects";
            bird.Color = "Red";
            bird.Habitat = "Forrest";
            bird.WingSpan = 12.2m;
            bird.WalkOnAllFours = false;
            bird.HairFurFeathers = "Feathers";


            var reptile = new Reptile();
            reptile.Species = "Komodo dragon";
            reptile.CanBeAPet = false;
            reptile.CanCamoflouge = true;
            reptile.Habitat = "Savanna";
            reptile.HairFurFeathers = "scales";
            reptile.DietConsists = "Large water buffalo to small insects or birds";
            reptile.ColdBloodedOrWarmBlooded = "cold blooded";
            reptile.WalkOnAllFours = true;

            Console.WriteLine($"Welcome to this very strange zoo exhibit featuring not only the infamous {reptile.Species}, but also its prey: the lovely {bird.Color} {bird.Species}.");
            Console.WriteLine($"The habitat for the {reptile.Species} is what you see here; the {reptile.Habitat}; which is very unfortunate for the {bird.Species} since it primarily dwells in the {bird.Habitat}...");
            Console.WriteLine($"Let's talk about their diets.  The {bird.Species} mainly consists of {bird.DietConsists}, while... oh my... the {reptile.Species} loves to enjoy {reptile.DietConsists}.");
            Console.WriteLine($"Tell me children, is it true that the {reptile.Species} makes a good pet!?");
            Console.WriteLine("'Type true or false...'");
            var answer = Console.ReadLine();
            if (answer == "True" || answer == "Yes" || answer == "true" || answer == "yes")
            {
                Console.WriteLine($"That is {reptile.CanBeAPet}! What are you thinking!?");
            }
            else
            {
                Console.WriteLine($"You are correct... they make a terrible pet. Believe me, I've tried.");
            }
            Console.WriteLine($"Well, now that we have that squared away, the {bird.Species} has {bird.HairFurFeathers} obviously, the {reptile.Species} has {reptile.HairFurFeathers}; it is {reptile.WalkOnAllFours} that the {reptile.Species} walks on all fours.\nAnd, it is clearly {bird.WalkOnAllFours} that a bird would walk on all fours.");
            Console.WriteLine($"And, now children, you can see that the {reptile.ColdBloodedOrWarmBlooded} reptile just ate the lovely {bird.Species} that had wingspan of {bird.WingSpan}inches in one fell swoop... ");
            Console.WriteLine($"Yes, children, it is {reptile.CanCamoflouge} that the {reptile.Species} can camoflouge... that's how it ate the little birdy.");
            Console.WriteLine("Fin...");
            

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

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
