using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Mad Libs
            Author: Daniel Binoy
            */


            // Let the user know that the program is starting:
            Console.WriteLine("To begin Mad Libs program, press enter");
            Console.ReadLine();

            // Give the Mad Lib a title:
            string title = "The very cool story";

            // Define user input and variables:
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a feeling");
            string feeling = Console.ReadLine();
            Console.WriteLine("Enter an adjective");
            string adj1 = Console.ReadLine();
            Console.WriteLine("Enter a noun that can be plural");
            string noun1 = Console.ReadLine();
            Console.WriteLine("Enter a product");
            string product = Console.ReadLine();
            Console.WriteLine("Enter a verb");
            string verb1 = Console.ReadLine();
            Console.WriteLine("Enter a noun that makes noise");
            string noun2 = Console.ReadLine();
            Console.WriteLine("Enter another adjective");
            string adj2 = Console.ReadLine();
            Console.WriteLine("Enter the name of a person");
            string name2 = Console.ReadLine();
            Console.WriteLine("Enter an adverb");
            string adv1 = Console.ReadLine();
            Console.WriteLine("Enter a location");
            string loc = Console.ReadLine();
            Console.WriteLine("Enter a liquid");
            string liq = Console.ReadLine();

            Console.WriteLine("Enter a large number");
            string num = Console.ReadLine();
            // The template for the story:

            string part1 = $"This morning {name} woke up feeling {feeling}. 'It is going to be a {adj1} day!' ";
            string part2 = $"Outside, a bunch of {noun1}s were protesting to keep {product} in stores.They began to {verb1} to the rhythm of the {noun2}, which made all the {noun1}s very {adj2}. ";
            string part3 = $"Concerned, {name} texted {name2}, who flew {adv1} to {loc} and dropped {product} in a puddle of frozen {liq}. {name2} woke up in the year {num}, in a world where {noun1}s ruled the world.";
            string story = $"{part1}\n{part2}\n{part3}";

            // Print the story:
            Console.WriteLine(story);
            Console.WriteLine("\n press enter to quit");
            Console.ReadLine();
        }
    }
}
