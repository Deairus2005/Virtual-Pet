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
		public void AddPet(Pet p)
		{
			PetList.Add(p);
		}
		public int GetPetCount()
		{
			return PetList.Count;
		}
		public void DisplayPets()
		{
			for(int i=0;i<PetList.Count;i++)
			{
				Console.WriteLine("Pet: "+(i+1)); //pet id.
				Console.WriteLine("Name: "+PetList[i].GetName()); //gets the name and prints it.
				Console.WriteLine("Species: "+PetList[i].GetSpecies()); //gets the species and prints it.
				Console.WriteLine(); //pet seperator.
			}
			
		}

		public void RemovePet(Pet p)
        {
			PetList.Remove(p);
		}
	}
}
