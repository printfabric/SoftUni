using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DecodeRadioFrequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringList = Console.ReadLine()
                .Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            var emptyList = new List<int>();

            for (int i = 0; i < stringList.Count; i++)
            {
                if(i % 2 == 0 && stringList[i] != 0)
                {
                    Console.Write((char)stringList[i]);
                }
            }

            stringList.Reverse();

            for (int i = 0; i < stringList.Count; i++)
            {
                if (i % 2 == 0 && stringList[i] != 0)
                {
                    Console.Write((char)stringList[i]);
                }
            }
        }
    }
}
