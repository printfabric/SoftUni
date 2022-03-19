using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.АМinerТask
{
    class Program
    {
        static void Main(string[] args)
        {
            var minerDict = new Dictionary<string, string>();
            var inputKey = "args";
            var inputValue = "args";

            while(inputKey != "stop")
            {
                inputKey = Console.ReadLine();
                inputValue = Console.ReadLine();

                if(inputKey != "stop" && inputValue != "stop")
                {
                    minerDict.Add(inputKey, inputValue);
                }
                else
                {
                    break;
                }

            }

            foreach (var kvp in minerDict)
            {
                Console.WriteLine(kvp.Key + " -> " + kvp.Value);
            }
        }
    }
}
