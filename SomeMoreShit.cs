// I have no Idea why I have to do this
using System;
using System.Linq;
// I have yet to understand why I need a namespace
namespace SomeShit
{
    // Why do I need a class?
    class SomeMoreShit
    {
        // Finally something makes sense, but why can I not name the Method something else?
        static void Main()
        {
            string[] CharTypes = { "Human", "Alien", "Robot", "Mortal Hybrid", "Immortal Hybrid", "Android", "Cyborg" };
            Console.WriteLine("Enter Character Name:");
            var CharName = Console.ReadLine();
            Console.WriteLine("What are you?");
            var CharType = Console.ReadLine();
            // Ok, took me an hour to find out that in order to use the Contains() Method, I needed to be "using System.Linq"...
            if (CharTypes.Contains(CharType))
            {
                Console.WriteLine("Thank you, " + CharName + ", you are now a Level 1 " + CharType + "!");
            }
            else
            {
                Console.WriteLine("Sorry, that is not a valid thing to be!");
                Main(); 
            }
            // Now what the hell can I define the Character as? And how?

        }
    }
}