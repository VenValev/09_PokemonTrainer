using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string text;
            List<Trainer> trainersList = new List<Trainer>();

            // Filling the pokemons

            while((text = Console.ReadLine()) != "Tournament")
            {
                bool isfound = false;
                string[] cmnd = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                Pokemon currentPokemon = new Pokemon(cmnd[1], cmnd[2], int.Parse(cmnd[3]));

                Trainer currentTrainer = new Trainer(cmnd[0], 0);
                
                foreach(Trainer t in trainersList)
                {
                    if(t.Name == currentTrainer.Name)
                    {
                        t.PokemonCollection.Add(currentPokemon);
                        isfound = true;
                        break;
                    }
                }

                if(isfound)
                {
                    continue;
                }
                else
                {
                    currentTrainer.PokemonCollection.Add(currentPokemon);
                    trainersList.Add(currentTrainer);
                }
            }

            string commands;

            while((commands = Console.ReadLine()) != "End")
            {
                if(commands == "Fire")
                {
                    

                    foreach(Trainer tr in trainersList)
                    {
                        bool isFound = false;

                        foreach (Pokemon p in tr.PokemonCollection)
                        {
                            if(p.Element == commands)
                            {
                                isFound = true;
                                break;
                            }
                        }
                        if(isFound)
                        {
                            tr.NumberOfBadges++;
                        }
                        else
                        {
                            foreach(Pokemon p in tr.PokemonCollection)
                            {
                                p.Health -= 10;
                            }
                        }
                    }
                }
                else if(commands == "Water")
                {

                }
                else if(commands == "Electricity")
                {

                }
            }
        }
    }
}
