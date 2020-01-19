namespace Projekt.Lumen
{
    public class Character
    {
        public int Level { get; private set; } = 1;
        public CharType Type { get; }
        public string Name { get; }

        public Character(string name, CharType type)
        {
            Name = name;
            Type = type;
        }

        public void IncreaseLevel() => Level++;

        public override string ToString()
        {
            return $"{Name} ({Type}), Level {Level}";
        }
    }
}
