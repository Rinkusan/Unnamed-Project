using System;

namespace Projekt.Lumen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character Name:");
            var charName = Console.ReadLine();
            Console.WriteLine("What are you?");
            var inputCharType = Console.ReadLine();

            var maybeCharType = CharType.From(inputCharType);
            if (maybeCharType == null)
            {
                Console.WriteLine("Sorry, that is not a valid thing to be!");
                return;
            }

            Console.WriteLine($"You chose to be a {maybeCharType.Name}: {maybeCharType.Description}");

            var character = new Character(charName, maybeCharType);
            Console.WriteLine($"Thank you! Your character: {character}");
            character.IncreaseLevel();
            Console.WriteLine($"Level up! Your character now: {character}");
        }
    }
}
