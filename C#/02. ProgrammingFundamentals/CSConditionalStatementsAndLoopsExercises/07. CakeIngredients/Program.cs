using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = -1;
            for (int i = 1; i > 0; i++)
            {
                count++;
                //Console.WriteLine(i);
                string ingredient = Console.ReadLine();

                if (ingredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                    break;
                }
                else
                {
                    
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                }
            }
        }
    }
}
