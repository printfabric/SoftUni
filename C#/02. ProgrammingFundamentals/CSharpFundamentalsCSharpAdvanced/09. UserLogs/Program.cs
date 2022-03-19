using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            //var str = "IP=192.23.30.40 message='Hello&derps.' user=destroyer";
            //var splStr = str.Split(' ');
            //var seconsSplStr = splStr[2].Split('=');

            //Console.WriteLine(splStr[2]);

            //Console.WriteLine(seconsSplStr[0] + " " + seconsSplStr[1]);

            var user = new SortedDictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine().Split(' ');
           
            while (input[0] != "end")
            {
                string[] splitUsername = input[2].Split('=');
                var name = splitUsername[1];

                string[] splitIP = input[0].Split('=');
                var IP = splitIP[1];

                string message = input[1];

                var splitUser = input[2].Split('=');

                //Chek did we already have the userName addet
                if (!user.ContainsKey(splitUser[1]))
                {
                    user[name] = new Dictionary<string, int>();
                }

                //add the IP to the user
                if (!user[name].ContainsKey(IP))
                {
                    user[name][IP] = new int();
                }
                user[name][IP]++;

                input = Console.ReadLine().Split(' ');
            }

            foreach (var us in user)
            {
                Console.WriteLine($"{us.Key}:");

                var counter = us.Value.Count;

                foreach (var IP in us.Value)
                {
                    counter--;
                    Console.Write($"{IP.Key} => {IP.Value}");
                    if (counter > 0)
                    {
                        Console.Write(", ");
                    }
                    else
                    {
                        Console.WriteLine(".");
                    }
                }
            }

        }
    }
}
