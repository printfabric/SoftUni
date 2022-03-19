using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var minerDict = new Dictionary<string, string>();
            var inputKey = "args";
            var inputValue = "args";

            while (inputKey != "stop")
            {
                inputKey = Console.ReadLine();
                inputValue = Console.ReadLine();

                var check = inputValue.Split('.');

                if (inputKey != "stop" && inputValue != "stop")
                {
                    if (check[1] == "bg" || check[1] == "BG")
                    {
                        minerDict.Add(inputKey, inputValue);
                    }
                    else
                    {
                    }
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
