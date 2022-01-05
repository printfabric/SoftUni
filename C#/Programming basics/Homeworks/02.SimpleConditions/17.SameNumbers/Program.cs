using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameNumbers
{
    class Program
    {
        static void Main(string[] args)
        {





            int wordnumberOne = int.Parse(Console.ReadLine());
            int wordnumberTwo = int.Parse(Console.ReadLine());
            int wordnumberThree = int.Parse(Console.ReadLine());



            if (wordnumberOne == wordnumberTwo)
            {
                if (wordnumberTwo == wordnumberThree)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
                               
            }
            else
            {
                Console.WriteLine("no");
            }








        }
    }
}
