using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine();
            var counter = 0;

            while(ingredients != "Bake!")
            {
                counter++;
                Console.WriteLine("Adding ingredient {0}.", ingredients);
                ingredients = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
