using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Trainer
    {
        private string name;
        private int numberOfBadges;
        List<Pokemon> pokemonCollection = new List<Pokemon>();

        

        public Trainer (string name, int numberOfBadges)
        {
            Name = name;
            NumberOfBadges = numberOfBadges;
            PokemonCollection = new List<Pokemon>();
        }

        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> PokemonCollection { get; set; }
    }
}
