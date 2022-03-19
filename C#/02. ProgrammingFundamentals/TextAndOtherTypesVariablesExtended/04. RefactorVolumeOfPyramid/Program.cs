using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //double Lenght, widht, heigth = 0;

            Console.Write("Length: ");

           var Lenght = double.Parse(Console.ReadLine());

            Console.Write("Width: ");

            var widht = double.Parse(Console.ReadLine());

            Console.Write("Height: ");

            var heigth = double.Parse(Console.ReadLine());

            heigth = (Lenght * widht * heigth) / 3;

            Console.WriteLine("Pyramid Volume: {0:F2}", heigth);
        }
    }
}
