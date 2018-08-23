using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog wash = new Dog("black lab", 100, false, "wash");
            Dog chance = new Dog("golden retriever", 200, "chance");
            wash.bark();
            chance.pet();
        }
    }
}
