namespace Projeto_RPG.src.Entities
{
    public class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public Character(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public override string ToString()
        {
            return Name 
            + " , "
            + Level
            + " , "
            + HeroType;
        }
    }
}