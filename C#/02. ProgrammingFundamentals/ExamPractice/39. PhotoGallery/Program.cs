using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var photoSize = double.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: DSC_{0:d4}.jpg", name);
            Console.WriteLine("Date Taken: {0:d2}/{1:d2}/{2:d4} {3:d2}:{4:d2}", day, month, year, hours, minutes);
            if (photoSize > 999999)
            {
                photoSize = Math.Round((photoSize / 1000000), 1);
                Console.WriteLine("Size: {0:f1}MB", photoSize);
            }
            else if (photoSize < 1000)
            {
                
                Console.WriteLine("Size: {0}B", photoSize);
            }
            else
            {
                photoSize = photoSize / 1000;
                Console.WriteLine("Size: {0}KB", photoSize);
            }

            if(width > height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else if (height > width)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");

            }
            else if (height == width)
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");

            }
        }
    }
}


