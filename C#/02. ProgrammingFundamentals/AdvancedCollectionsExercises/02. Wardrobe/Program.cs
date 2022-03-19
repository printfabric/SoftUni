using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, int>>();
            int inputCnt = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < inputCnt; cnt++)
            {
                string[] inputTokens = Console.ReadLine().Split(new string[] { " -> " }
                , StringSplitOptions
                .RemoveEmptyEntries);

                string color = inputTokens[0];
                string[] clothes = inputTokens[1].Split(',');

                if (!data.ContainsKey(color))
                {
                    data.Add(color, new Dictionary<string, int>());
                }

                foreach (var cloth in clothes)
                {
                    Dictionary<string, int> clothDb = data[color];
                    if (!clothDb.ContainsKey(cloth))
                    {
                        clothDb.Add(cloth, 0);
                    } 

                    clothDb[cloth]++;
                }

            }

            string[] searchTokens = Console.ReadLine().Split(' ');
            string searchedColor = searchTokens[0];
            string searchedCloth = searchTokens[1];

            foreach (var colorData in data)
            {
                string color = colorData.Key;
                Dictionary<string, int> clothesData = colorData.Value;
                Console.WriteLine("{0} clothes:", color);

                foreach (var clothData in clothesData)
                {
                    string cloth = clothData.Key;
                    int quantity = clothData.Value;

                    Console.Write("* {0} - {1}", cloth, quantity);

                    if(color == searchedColor && cloth == searchedCloth)
                    {
                        Console.Write(" (found!)");
                    }
                        Console.WriteLine();
                }

            }

        }
    }
}
