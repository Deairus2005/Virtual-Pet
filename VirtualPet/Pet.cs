using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet

    {
        private string Name
        {
            get; set;
        }
        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;

        }

        public string Species { get; set; }

        public void SetSpecies(string species)
        {
            Species = species;
        }

        public string GetSpecies()
        {
            return Species;

        }
        public int Hunger = 50;
        public int GetHunger()
        {
            return Hunger;
        }

        public int Boredom = 60;
        public int GetBoredom()
        {
            return Boredom;
        }

    }

}
