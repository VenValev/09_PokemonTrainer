using System;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string text;

            while((text = Console.ReadLine()) != "Tournament")
            {
                string[] cmnd = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                Pokemon currentPokemon = new Pokemon(cmnd[1], cmnd[2], int.Parse(cmnd[3]));

                Trainer currentTrainer = new Trainer(cmnd[0], 0);
                currentTrainer.PokemonCollection.Add(currentPokemon);
            }

            string commands;

            while((commands = Console.ReadLine()) != "End")
            {

            }
        }
    }
}
