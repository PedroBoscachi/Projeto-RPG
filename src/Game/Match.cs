using System;
using System.Collections.Generic;
using Projeto_RPG.src.Entities;

namespace Projeto_RPG.src.Game
{
    public class Match
    {
        List<Character> CharactersList = new List<Character>();
        
        
        public Match(){
            SetBoard();          
        }
        
        

        public void ShowBoard()
        {
            foreach(Character c in CharactersList)
            {
                Console.WriteLine(c);
            }
        }

        public void SetBoard()
        {
            

            CharactersList.Add(new Archer("Lafro", 9, "Archer", 70));
            CharactersList.Add(new Assassin("Asmos", 11, "Assassin", 50));
            CharactersList.Add(new Berserker("Atia", 10, "Berserker", 90));
            CharactersList.Add(new Cleric("Samia", 9, "Cleric", 40));
            CharactersList.Add(new Warrior("Patrias", 13, "Warrior", 100));
            CharactersList.Add(new Wizard("Patritia", 12, "Wizard", 60));
        }

        public Character FindCharacter(string name){
            foreach (Character c in CharactersList)
            {
                if(c.Name == name)
                {
                    return c;
                }
            }

            throw new FormatException("Character not found");
        }

        public void DamageCharacter(Character c)
        {
            c.Life -= 8;
        }
    }
}