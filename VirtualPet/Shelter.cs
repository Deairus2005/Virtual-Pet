using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
	public class Shelter
	{
		public List<Pet> NormalPetList=new List<Pet>();
		public System.Collections.Generic.List<RoboPet> RoboPetList=new System.Collections.Generic.List<RoboPet>();
		public Pet SelectedPet;
		public void AddPet(Pet p)
		{
			NormalPetList.Add(p);
		}
		public void AddPet(RoboPet p)
		{
			RoboPetList.Add(p);
		}
		public void RemovePet(Pet p)
        {
			NormalPetList.Remove(p);
		}
		public void RemovePet(RoboPet p)
        {
			RoboPetList.Remove(p);
		}
		public int GetPetCount()
		{
			return NormalPetList.Count;
		}
		public void DisplayPets()
		{
			if(NormalPetList.Count<=0&&RoboPetList.Count<=0)
			{
				Console.WriteLine("There are no pets in the shelter.");
				return;
			}
			for(int i=0;i<NormalPetList.Count;i++)
			{
				Console.WriteLine("Pet: "+(i+1)); //pet id.
				Console.WriteLine("Name: "+NormalPetList[i].GetName()); //gets the name and prints it.
				Console.WriteLine("Species: "+NormalPetList[i].GetSpecies()); //gets the species and prints it.
				Console.WriteLine("Hunger: "+NormalPetList[i].GetHunger()); //gets the hunger and prints it.
				Console.WriteLine("Boredom: "+NormalPetList[i].GetBoredom()); //gets the boredom and prints it.
				Console.WriteLine("Health: "+NormalPetList[i].GetHealth()); //gets the health and prints it.
				if(i!=(NormalPetList.Count()-1))
					Console.WriteLine(); //pet seperator.
			}

			Console.WriteLine();

			for(int i=0;i<RoboPetList.Count;i++)
			{
				Console.WriteLine("Robo Pet: "+(i+1)); //pet id.
				Console.WriteLine("Name: "+RoboPetList[i].GetName()); //gets the name and prints it.
				Console.WriteLine("Species: "+RoboPetList[i].GetSpecies()); //gets the species and prints it.
				Console.WriteLine("Oil Level: "+RoboPetList[i].GetOilLevel()); //gets the oil level and prints it.
				Console.WriteLine("Battery Level: "+RoboPetList[i].GetBatteryLevel()); //gets the battery level and prints it.
				Console.WriteLine("Heat Level: "+RoboPetList[i].GetHeatLevel()); //gets the heat level and prints it.
				if(i!=(RoboPetList.Count()-1))
					Console.WriteLine(); //pet seperator.
			}
		}
		public void SelectAPet()
        {
			Console.WriteLine("Select A Pet to Interact with");
			for (int i = 0; i < NormalPetList.Count; i++) //prints the pets.
			{
				Console.WriteLine("Pet " + (i + 1) + ": " + NormalPetList[i].GetName());
			}
			int PetToSelect = Convert.ToInt32(Console.ReadLine());
			SelectedPet = NormalPetList[PetToSelect - 1];


		}
	}
}
