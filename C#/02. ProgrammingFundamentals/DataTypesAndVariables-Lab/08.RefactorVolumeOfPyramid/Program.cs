﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Length: ");
            var length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            var width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            var  height = double.Parse(Console.ReadLine());
            
            
                       
            var pyramideVolume = (length * width * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", pyramideVolume);

        }
    }
}
