using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContentPer100 = double.Parse(Console.ReadLine());
            var sugarContentPer100 = double.Parse(Console.ReadLine());

            var energyCuntent = volume * (energyContentPer100 / 100);
            var sugarCuntemtnt = volume * (sugarContentPer100 / 100);

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyCuntent}kcal, {sugarCuntemtnt}g sugars");

        }
    }
}
