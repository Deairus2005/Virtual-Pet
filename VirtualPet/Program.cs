using System;

namespace VirtualPet
{
    class Program
    {
        /*
            Development of a console application
            Use of Test Driven Development
            Clean code
            Appropriate use of Git and access to your application on GitHub
            An interactive user interface
            Ability for players to enter the game, play as long as they’d like, and leave the game when they want
            Ability for players to enter a name and species for a pet
            Ability for players to see the current status of a pet, such as hunger, boredom, and health
            Ability for players to interact with pet, such as feed, play, and take to doctor
            As players interact with pet, the pet’s status changes
            As “time” ticks by, the pet’s status changes negatively
        */
        private static Shelter TheShelter=new Shelter();
        static void Main(string[] args)
        {
            /*
            Pet pet1 = new Pet();

            Console.WriteLine("Enter your pet's name");
            string userInput = Console.ReadLine();
            pet1.SetName(userInput);

            Console.WriteLine("Enter Pet Species Here:");
            string userSpecies = Console.ReadLine();
            pet1.SetSpecies(userSpecies);
            */

            //Pet 1
            Pet Dog=new Pet();
            Dog.SetName("Skippy");
            Dog.SetSpecies("Dog");
            TheShelter.AddPet(Dog);

            //Pet 2
            Pet Cat=new Pet();
            Cat.SetName("Desmond");
            Cat.SetSpecies("Cat");
            TheShelter.AddPet(Cat);

            //Pet 3
            Pet Fish=new Pet();
            Fish.SetName("Flipper");
            Fish.SetSpecies("Fish");
            TheShelter.AddPet(Fish);
            
            TheShelter.DisplayPets();

            /*
            bool IsRunning=true;
            while(IsRunning)
			{
                Console.Clear();
                Console.WriteLine("Hello! Welcome to Virtual Pets\n");

                Console.WriteLine("1: Option 1");
                Console.WriteLine("2: Option 2");
                Console.WriteLine("3: Option 3");
                Console.WriteLine("4: Option 4");
                Console.WriteLine("5: Option 5");
                Console.WriteLine("6: Option 6");
                Console.WriteLine("7: Option 7");
                Console.WriteLine("8: Option 8");
                Console.WriteLine("9: Option 9");
                Console.WriteLine("10: Option 10");
                Console.WriteLine("E: Exit");

                string Input=Console.ReadLine();
                
				switch(Input.ToUpper())
				{
                    case "1":break;
                    case "2":break;
                    case "3":break;
                    case "4":break;
                    case "5":break;
                    case "6":break;
                    case "7":break;
                    case "8":break;
                    case "9":break;
                    case "10":break;
                    case "E":IsRunning=false;break;
                    default:Console.WriteLine("Enter a valid option please...");Console.ReadLine();break;
                }
			}
            */
        }
    }
}
