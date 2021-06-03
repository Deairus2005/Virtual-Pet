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

        public int Health = 30;
        public int GetHealth()
        {
            return Health;
        }
        public void Feed() 
        {
            Hunger = Hunger - 40;
        }

        public void SeeDoctor()
		{
            Health = Health + 30;
		}

        public void Play()
		{
            Hunger = Hunger + 10;
            Boredom = Boredom - 20;
            Health = Health + 10;
		}
        public void Tick()
		{
            Hunger = Hunger + 5;
            Boredom = Boredom + 5;
            Health = Health - 5;
		}
    }

        

}
