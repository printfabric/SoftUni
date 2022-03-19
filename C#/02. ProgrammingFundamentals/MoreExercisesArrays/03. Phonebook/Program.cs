using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfNumbers = Console.ReadLine().Split(new[] { ' ' },
                      StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] arrayOfNames = Console.ReadLine().Split(new[] { ' ' },
                      StringSplitOptions.RemoveEmptyEntries).ToArray();           
            string emptyString = string.Empty;
            var counter = 0;

            for (int i = 0; i < 1; i--)
            {
                string name = Console.ReadLine();
                if (name == "done")
                {
                    break;
                }
                counter++;

                emptyString = emptyString + name + " ";
            }            

            string[] arrayOfNamess = emptyString.Split(new[] { ' ' },
                      StringSplitOptions.RemoveEmptyEntries).ToArray();            

            for (int i = 0; i < arrayOfNumbers.Length ; i++)
            {
                for (int j = 0; j <= counter-1; j++)
                {
                    if (arrayOfNames[i] == arrayOfNamess[j])
                    {
                        Console.WriteLine("{0} -> {1}", arrayOfNames[i], arrayOfNumbers[i]);
                    }
                }

            }    
        }
    }
}
