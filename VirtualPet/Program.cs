using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Virtual Pets");
            Pet pet1 = new Pet();
            Console.WriteLine("Enter your pet's name");
            string userInput = Console.ReadLine();
            pet1.SetName  (userInput);
        }
    }
}
