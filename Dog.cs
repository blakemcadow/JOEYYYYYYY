using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dog : Animal
    {

        public Dog(string startBreed, int startingHappiness, bool startIsWalking, string startName)
        {
            breed = startBreed;
            happiness = startingHappiness;
            IsWalking = startIsWalking;
            name = startName;
        }

        public Dog(string startBreed, int startinghappiness, string startName)
        {
            breed = startBreed;
            happiness = startinghappiness;
            name = startName;
        }
        public void bark()
        {
            Console.WriteLine("The dog " + name + " said \"Woof!\" ");
            Console.ReadLine();
        }

        public void pet()
        {
            happiness += 10;
            Console.WriteLine(name + " liked that a lot");
            Console.WriteLine(name + "'s happiness is now " + happiness.ToString());
            Console.ReadLine();
            Console.WriteLine("poo");
        }
    }
}
