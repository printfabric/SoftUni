using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var BPM = double.Parse(Console.ReadLine());
            var beats = double.Parse(Console.ReadLine());
            var length = Math.Floor(beats / (BPM / 60));
            Console.Write("{0} bars ", Math.Round((beats/4),1));
            
            if(length > 59)
            {
                Console.WriteLine("- 1m {0}s", (length - 60));
            }
            else
            {
                Console.WriteLine("- 0m {0}s", length);

            }
        }
    }
}
