using System;
using System.Collections.Generic;

namespace GetDisplayUserInfo_McGuire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there! I just need some basic info!");

            string firstName = GetStringUserInfo("What is your first name?");
            string lastName = GetStringUserInfo("What is your last name?");
            int favoriteNumber = GetIntUserInfo("What is your favorite number?");
            int numberOfPets = GetIntUserInfo("How many pets do you have?");
            List<string> nameOfPets = PetNames("What are the names of your pets?", numberOfPets);
            

            Console.WriteLine("Your name is " + firstName + " " + lastName + ".");
            Console.WriteLine("Your favorite number is " + favoriteNumber + ".");
            Console.WriteLine("You have " + numberOfPets + " pets.");
            Console.WriteLine("Your pet names are: ");
            foreach (var name in nameOfPets)
            {
                Console.WriteLine(name);
            }


        }

        static string GetStringUserInfo(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            return answer;
        }

        static int GetIntUserInfo(string question)
        {
            Console.WriteLine(question);
            int answer = Int32.Parse(Console.ReadLine());
            return answer;
        }

        public static List<string> PetNames(string question, int range)
        {
            Console.WriteLine(question);
            List<string> nameOfPets = new List<string>();
            for (int i = 0; i < range; i++)
            {
                Console.WriteLine("Type a pet's name:");
                string answer = Console.ReadLine();
                nameOfPets.Add(answer);

            }
            return nameOfPets;
        }
    }
}
