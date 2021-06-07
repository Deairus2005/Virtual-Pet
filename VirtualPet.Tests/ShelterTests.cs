using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace VirtualPet.Tests
{
	public class ShelterTests
	{
		private Shelter DemoShelter;
		public ShelterTests()
		{
			DemoShelter=new Shelter();
		}
		[Fact]
		public void Add_A_Pet_Should_Increment_Pets_by_1()
		{
			//Arrange.
			Pet DemoPet=new Pet();

			//Act.
			DemoShelter.AddPet(DemoPet);

			//Assert.
			Assert.Equal(1,DemoShelter.GetPetCount());
		}

		[Fact]

		public void Remove_A_Pet_Should_Decrement_Pets_by_1()
        {
			//Arrange.
			Pet DemoPet = new Pet();


			//Act.
			DemoShelter.AddPet(DemoPet);
			DemoShelter.RemovePet(DemoPet);


			//Assert.
			Assert.Equal(0, DemoShelter.GetPetCount());


		}

		//Ability for players to 
		//interact with pet, 
         //such as feed, play, 
         //and take to doctor







	}
}
