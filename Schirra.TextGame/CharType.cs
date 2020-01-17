using System.Collections.Generic;
using System.Linq;

namespace Schirra.TextGame
{
    public class CharType
    {
        public static readonly CharType Human = new CharType("Human", "The most dangerous species on planet earth.");
        public static readonly CharType Alien = new CharType("Alien", "An extra-terrestrial life form.");

        public static readonly IReadOnlyList<CharType> All = new[] {Human, Alien};

        public static CharType From(string input)
        {
            return All.FirstOrDefault(charType => Equals(input, charType.Name));
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
