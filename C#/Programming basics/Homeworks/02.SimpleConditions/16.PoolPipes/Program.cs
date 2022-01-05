using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            double V = double.Parse(Console.ReadLine());
            double P1 = double.Parse(Console.ReadLine());
            double P2 = double.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double sumPipes = P1 + P2;
            double x = (sumPipes * H) / V * 100;            
            var y = (P1 / sumPipes) * 100;
            var z = (P2 / sumPipes) * 100;
            var a = sumPipes * H;
            //var xRound = Math.Round(x);
            //var yRound = Math.Round(y);
            //var zRound = Math.Round(z);
            var xOverFlow = (sumPipes * H) - V;
            if (a <= V)
            {
                Console.WriteLine("The pool is " +(int)(x) + "% " + "full. " +
                    "Pipe 1: " + (int)(y) + "%. " + "Pipe 2: " + (int)(z) + "%.");
            }
            else if (a > V)
            {
                Console.WriteLine("For " + H + " hours the pool overflows with " + xOverFlow + " liters.");
            }

            

        }
    }
}
