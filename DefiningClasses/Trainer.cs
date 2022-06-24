using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Trainer
    {
        private string name;
        private int numberOfBadges;
        List<string> pokemonCollection;

        public Trainer()
        {
            pokemonCollection = new List<string>();
        }
    }
}
