using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        private string Name{get;set;}
        public void SetName(string NameToSet){Name = NameToSet;}
        public string GetName(){return Name;}
        

        private string Species { get; set; }
        public void SetSpecies(string SpeciesToSet){ Species = SpeciesToSet;}
        public string GetSpecies(){return Species;}


        private int Hunger = 50;
        public void SetHunger(int HungerLevel) { Hunger = HungerLevel;}
        public int GetHunger(){return Hunger;}


        private int Boredom = 60;
        public void SetBoredom(int BoredomLevel) { Boredom = BoredomLevel;}
        public int GetBoredom(){return Boredom;}


        private int Health = 30;
        public void SetHealth(int HealthNumber) { Health = HealthNumber;}
        public int GetHealth(){return Health;}


        private int Ceiling(int Input,int Addition)
		{
            if(Input+Addition>100)
                return 100;
            else
                return Input+Addition;
		}
        private int Floor(int Input,int Subtraction)
		{
            if(Input-Subtraction<0)
                return 0;
            else
                return Input-Subtraction;
		}
        
        public void Feed()
        {
            Hunger=Floor(Hunger,40);
        }
        public void SeeDoctor()
		{
            Health=Ceiling(Health,30);
		}
        public void Play()
		{
            Health=Ceiling(Health,10);
            Hunger=Ceiling(Hunger,10);
            Boredom=Floor(Boredom,20);
		}
        public void Tick()
		{
            Health=Floor(Health,5);
            Hunger=Ceiling(Hunger,5);
            Boredom=Ceiling(Boredom,5);
		}
        public void TakeANap()
        {
            Health=Ceiling(Health,10);
            Hunger=Floor(Hunger,5);
            Boredom=Ceiling(Boredom,10);
        }
        public void TakeToDoctor()
        {
            Health=Ceiling(Health,20);
            Hunger=Ceiling(Hunger,10);
            Boredom=Ceiling(Boredom,5);
        }
    }
}
