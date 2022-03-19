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
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            var health = currentHealth + 1;
            var healthBlanks = maxHealth - currentHealth;

            var energy = currentEnergy + 1;
            var energyBlanks = maxEnergy - currentEnergy;

            Console.WriteLine($"Name: {name}");
            Console.Write("Health: ");
            Console.Write(new string('|', health));
            Console.Write(new string('.', healthBlanks));
            Console.Write("|");
            Console.WriteLine();

            Console.Write("Energy: ");
            Console.Write(new string('|', energy));
            Console.Write(new string('.', energyBlanks));
            Console.Write("|");

        }
    }
}
