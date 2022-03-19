using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last3ConsecutiveEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(new[] { ' ' },
                      StringSplitOptions.RemoveEmptyEntries).ToArray();         

            for (int i = array.Length -1; i > 0; i--)
            {
                if(array[i] == array[i-1] && array[i-1] == array[i-2])
                {
                    Console.WriteLine("{0} {0} {0}", array[i]);
                    break;
                }
                
            }

            
        }
    }
}
