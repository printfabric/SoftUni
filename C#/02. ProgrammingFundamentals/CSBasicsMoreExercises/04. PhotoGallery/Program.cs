using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPhoto = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var size = double.Parse(Console.ReadLine());
            var resolutionWidth = int.Parse(Console.ReadLine());
            var resolutionHeight = int.Parse(Console.ReadLine());
            string orientation = null;
            string sizeType = null;
            var sizeConvertion = 0.0;

            if (resolutionWidth < resolutionHeight)
            {
                orientation = "(portrait)";
            }
            else if (resolutionWidth > resolutionHeight)
            {
                orientation = "(landscape)";
            }
            else if (resolutionWidth == resolutionHeight)
            {
                orientation = "(square)";
            }


            if (size <= 999)
            {
                sizeType = "B";
                sizeConvertion = size;
            }
            else if (size > 999 && size <= 999999)
            {
                sizeType = "KB";
                sizeConvertion = size / 1000;
            }
            else if (size > 999999)
            {
                sizeType = "MB";
                sizeConvertion = size / 1000000;
            }

            Console.WriteLine("Name: DSC_{0:d4}.jpg", numberOfPhoto);
            Console.WriteLine("Date Taken: {0:d2}/{1:d2}/{2:d2} {3:d2}:{4:d2}", day, month, year, hours, minutes);
            Console.WriteLine($"Size: {sizeConvertion}{sizeType}");
            Console.WriteLine($"Resolution: {resolutionWidth}x{resolutionHeight} {orientation}");

        }
    }
}
