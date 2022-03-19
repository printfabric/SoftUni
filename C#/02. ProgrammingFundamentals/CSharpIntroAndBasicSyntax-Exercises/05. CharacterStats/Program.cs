using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealt = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            var health = currentHealth + 1;
            var blanks = maxHealt - currentHealth;
            var energy = currentEnergy + 1;
            var blanksEnergy = maxEnergy - currentEnergy;


            //Health

            Console.WriteLine($"Name: {name}");
            Console.Write($"Health: ");
            Console.Write(new string('|', health));
            Console.Write(new string('.', blanks));
            Console.Write("|");
            Console.WriteLine();
            
            //Energy

            Console.Write($"Energy: ");
            Console.Write(new string('|', energy));
            Console.Write(new string('.', blanksEnergy));
            Console.Write("|");


        }
    }
}
