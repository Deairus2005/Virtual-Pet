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
		public void Add_A_Pet()
		{
			//Arrange.
			Pet DemoPet=new Pet();

			//Act.
			DemoShelter.AddPet(DemoPet);

			//Assert.
			Assert.Equal(1,DemoShelter.GetPetCount());
		}
	}
}
