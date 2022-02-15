using Projeto_RPG.src.Interfaces;

namespace Projeto_RPG.src.Entities
{
    public abstract class Character : IReceiveDamage
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int Life { get; set; }

        public Character(string name, int level, string heroType, int life)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
            Life = life;
        }

        protected Character(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public void TookDamage(int damage)
        {
            Life -= damage;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Character))
            {
                return false;
            }

            Character other = obj as Character;
            return Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        
        public override string ToString()
        {
            return Name 
            + " , Level:"
            + Level
            + " , Class: "
            + HeroType
            + " , Life: "
            + Life;
        }

        
    }
}