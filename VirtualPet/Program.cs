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
            //Default Pets.
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
            
            

            
            bool IsRunning=true;
            while(IsRunning)
			{
                Console.Clear();
                Console.WriteLine("Hello! Welcome to Virtual Pets\n");

                Console.WriteLine("1: Display all pets in shelter.");
                Console.WriteLine("2: Add a pet to the shelter.");
                Console.WriteLine("3: Remove a pet from the shelter.");
                Console.WriteLine("4:  Interact with a Pet");
                Console.WriteLine("5: Feed Pet");
                Console.WriteLine("6: Play with Pet");
                Console.WriteLine("7: Take Pet to the Doctor");
                Console.WriteLine("8: Option 8");
                Console.WriteLine("9: Option 9");
                Console.WriteLine("10: Option 10");
                Console.WriteLine("11: Option 11");
                Console.WriteLine("12: Option 12");
                Console.WriteLine("13: Option 13");
                Console.WriteLine("14: Option 14");
                Console.WriteLine("15: Option 15");
                Console.WriteLine("E: Exit");

                string Input=Console.ReadLine();
                
                Console.Clear();
				switch(Input.ToUpper())
				{
                    case "1":
                        TheShelter.DisplayPets();
                    break;
                    case "2":
                        Pet NewPet=new Pet();

                        Console.WriteLine("What's your pets name?");
                        NewPet.SetName(Console.ReadLine());

                        Console.WriteLine("What's your pets species?");
                        NewPet.SetSpecies(Console.ReadLine());

                        TheShelter.AddPet(NewPet);
                        Console.WriteLine("Your pet has been added to the shelter.");
                    break;
                    case "3":
                        if(TheShelter.PetList.Count<=0)
                        {
                            Console.WriteLine("There are no pets to remove from the shelter.");
                            break;
                        }

                        Console.WriteLine("Select a pet to remove from the shelter.");
                        for(int i=0;i<TheShelter.PetList.Count;i++) //prints the pets.
						{
                            Console.WriteLine("Pet "+(i+1)+": "+TheShelter.PetList[i].GetName());
						}
                        int PetToRemove=Convert.ToInt32(Console.ReadLine());

                        if(TheShelter.SelectedPet == TheShelter.PetList[PetToRemove - 1])
                        {
                            TheShelter.SelectedPet = null;
                        }

                        string PetNameThatHasBeenRemoved=TheShelter.PetList[ (PetToRemove-1) ].GetName();
                        TheShelter.RemovePet( TheShelter.PetList[ (PetToRemove-1) ] );
                        Console.WriteLine(PetNameThatHasBeenRemoved+" was removed from the shelter.");
                        break;
                    case "4":
                        TheShelter.SelectAPet();
                    break;
                    case "5":
                         TheShelter.SelectedPet.Feed();
                        Console.WriteLine("You've Fed " + TheShelter.SelectedPet.GetName());
                    break;
                    case "6":
                        TheShelter.SelectedPet.Play();
                        Console.WriteLine("You've Played with " + TheShelter.SelectedPet.GetName());

                        break;
                    case "7":
                        TheShelter.SelectedPet.TakeToDoctor();
                        Console.WriteLine("You've Taken " + TheShelter.SelectedPet.GetName() + " to the Doctor");

                        break;
                    case "8":

                    break;
                    case "9":

                    break;
                    case "10":

                    break;
                    case "11":

                    break;
                    case "12":

                    break;
                    case "13":

                    break;
                    case "14":

                    break;
                    case "15":

                    break;
                    case "E":
                        IsRunning=false;
                    break;
                    default:
                        Console.WriteLine("Enter a valid option please...");
                    break;
                }
                Console.ReadLine();
			}
            
        }
    }
}
