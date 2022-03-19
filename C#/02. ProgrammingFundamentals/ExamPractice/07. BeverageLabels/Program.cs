using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugar = int.Parse(Console.ReadLine());

            var kKal = (volume / 100) * energyContent;
            
            var sugarContent = sugar * (volume / 100);

            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", kKal, sugarContent);
        }
    }
}
