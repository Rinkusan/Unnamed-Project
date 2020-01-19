using System.Collections.Generic;
using System.Linq;

namespace Projekt.Lumen // creates namespace
{
    public class CharType // creates Class CharType
    {
        public static readonly CharType Human = new CharType("Human", "The most dangerous species on planet earth."); // Creates Class Object Human
        public static readonly CharType Alien = new CharType("Alien", "An extra-terrestrial life form."); // Creates Class Object Human

        public static readonly IReadOnlyList<CharType> All = new[] {Human, Alien}; // Creates "All", a Read-Only Collection of Elements (Objects) containing the Objects

        public static CharType From(string input) // Cant find documentation on method
        {
            return All.FirstOrDefault(charType => Equals(input, charType.Name)); // Returns the first value in the sequence "charType" if "input" - "inputCharType" from Program.cs equals the charType.Name?
        }

        public string Name { get; }
        public string Description { get; }

        private CharType(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}