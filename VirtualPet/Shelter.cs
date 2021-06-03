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
	}
}
