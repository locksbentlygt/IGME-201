using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
           Potion myCustomPotion = new Potion("red",20,"hot death","to cause a hot death...duh",7);
           Potion defaultPotion = new Potion();
            myCustomPotion.printPotion();
            defaultPotion.printPotion();
            myCustomPotion.usePotion();
            myCustomPotion.printPotion();
            Console.ReadLine();


        }
    }
}
