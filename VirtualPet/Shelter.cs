using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
	public class Shelter
	{
		public List<Pet> PetList=new List<Pet>();
		public Pet SelectedPet;
		public void AddPet(Pet p)
		{
			PetList.Add(p);
			
		}
		public void RemovePet(Pet p)
        {
			PetList.Remove(p);
		}
		public int GetPetCount()
		{
			return PetList.Count;
		}
		public void DisplayPets()
		{
			if(PetList.Count<=0)
			{
				Console.WriteLine("There are no pets in the shelter.");
				return;
			}
			for(int i=0;i<PetList.Count;i++)
			{
				Console.WriteLine("Pet: "+(i+1)); //pet id.
				Console.WriteLine("Name: "+PetList[i].GetName()); //gets the name and prints it.
				Console.WriteLine("Species: "+PetList[i].GetSpecies()); //gets the species and prints it.
				Console.WriteLine("Hunger: "+PetList[i].GetHunger()); //gets the hunger and prints it.
				Console.WriteLine("Boredom: "+PetList[i].GetBoredom()); //gets the boredom and prints it.
				Console.WriteLine("Health: "+PetList[i].GetHealth()); //gets the health and prints it.
				if(i!=(PetList.Count()-1))
					Console.WriteLine(); //pet seperator.
			}
		}
		public void SelectAPet()
        {
			Console.WriteLine("Select A Pet to Interact with");
			for (int i = 0; i < PetList.Count; i++) //prints the pets.
			{
				Console.WriteLine("Pet " + (i + 1) + ": " + PetList[i].GetName());
			}
			int PetToSelect = Convert.ToInt32(Console.ReadLine());
			SelectedPet = PetList[PetToSelect - 1];


		}
	}
}
