using System;
using System.Collections.Generic;
using Projeto_RPG.src.Entities;
using Projeto_RPG.src.Game;


namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Match match = new Match();
            match.ShowBoard();

            bool finished = false;

            do{

                System.Console.WriteLine("");

                Console.Write("Write the name of a character to receive damage: ");
                string nameCharacter = Console.ReadLine();

                match.DamageCharacter(match.FindCharacter(nameCharacter));

                Console.Clear();

                match.ShowBoard();

                Console.WriteLine();

                Console.Write("Do you want to continue? [Y/N]: ");
                char choice = char.Parse(Console.ReadLine());

                Console.Clear();
                match.ShowBoard();

                if(Char.ToUpper(choice) == 'N')
                {
                    finished = true;
                }

            }while(finished == false);

        }
    }
}
