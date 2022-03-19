using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
           // string str = "";            
            var myDict = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if(!myDict.ContainsKey(input[i]))
                {
                    myDict.Add(input[i], 0);
                }
                myDict[input[i]]++;
            }

            foreach (var kvp in myDict)
            {
                // str = kvp.Key.ToString();
                Console.WriteLine(kvp.Key + ": " + kvp.Value + " time/s");
            }
        }
    }
}
