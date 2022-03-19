using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var BPM = double.Parse(Console.ReadLine());
            var numberOfBeats = double.Parse(Console.ReadLine());
            var BPS = (BPM / 60);
            var numberOfBeatsPerSecond = numberOfBeats / BPS;
            var seconds = numberOfBeatsPerSecond % 60;
            var minutes = numberOfBeatsPerSecond / 60;
            var bars = ((double)numberOfBeats / 4);
            bars = Math.Round(bars, 1);
          

            Console.Write($"{bars} bars - ");
            Console.Write("{0:f0}m {1:f0}s", Math.Floor(minutes), Math.Floor(seconds));
            Console.WriteLine();
            
            


        }
    }
}
