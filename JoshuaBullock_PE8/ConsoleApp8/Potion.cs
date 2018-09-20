using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Potion
    {

        string color;
        double strength;
        string name;
        string usage;
        double dosage;
        
        public Potion(string p_color, double p_strength, string p_name, string p_usage, double p_dosage)
        {
            color = p_color;
            strength = p_strength;
            name = p_name;
            usage = p_usage;
            dosage = p_dosage;
        }

        public Potion()
        {
            name = "Potion";
            strength = 50;
            color = "colorless";
            usage = "to cast on a person";
            dosage = 10;
            
        }

        public void usePotion()
        {
            dosage = dosage -1;
            Console.WriteLine("WHY DID YOU DRINK ONE!!!...now we only have {0} doses left!\n",dosage);
        }

        public void printPotion()
        {
            Console.WriteLine("The name of this potion is {0} \n its strength is {1}.\n its color is labeld as {2} \n you use it {3}.\n and its dosage is {4} \n" ,name,strength,color,usage,dosage);
        }

    }
}
