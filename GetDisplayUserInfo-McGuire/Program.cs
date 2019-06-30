using System;

namespace GetDisplayUserInfo_McGuire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there! I just need some basic info!");

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            int favoriteNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("How many pets do you have?");
            int numberOfPets = int.Parse(Console.ReadLine());

           //Do a list or array of pet names

        }
    }
}
