using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program Maakt een klein verhaal met input van de gebruiker
            Author: Thimo Spijker
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Laten we beginnen een verhaal te maken.");

            // Give the Mad Lib a title:
            string title = "Een dag uit het levern van:";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("Enter a Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter a mood: ");
            string mood = Console.ReadLine();
            Console.Write("Enter a favorite color: ");
            string favColor = Console.ReadLine();
            Console.Write("Enter a favorite texture: ");
            string favTexture = Console.ReadLine();
            Console.Write("Enter a action like sit, sleep, eat, etc: ");
            string action = Console.ReadLine();
            Console.Write("Enter a person like girl or boy: ");
            string person = Console.ReadLine();
            Console.Write("Enter a place: ");
            string place = Console.ReadLine();
            Console.Write("Enter a Animal: ");
            string animal = Console.ReadLine();
            Console.Write("Entar a food: ");
            string food = Console.ReadLine();
            Console.Write("Enter a Fruit: ");
            string fruit = Console.ReadLine();
            Console.Write("Enter a superhero: ");
            string superHero = Console.ReadLine();
            Console.Write("Enter a Country: ");
            string country = Console.ReadLine();
            Console.Write("Enter a dessert: ");
            string dessert = Console.ReadLine();
            Console.Write("Enter a year: ");
            string year = Console.ReadLine();


            // The template for the story:

            string story = $"This morning {name} woke up feeling {mood}. 'It is going to be a {favColor} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {action} to the rhythm of the {person}, which made all the {fruit}s very {favTexture}. Concerned, {name} texted {superHero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {place}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}
