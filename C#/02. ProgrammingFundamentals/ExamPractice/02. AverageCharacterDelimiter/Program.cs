using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AverageCharacterDelimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringList = Console.ReadLine().Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries).ToList();
            var newList = new List<int>();
            var sum = 0;

            for (int i = 0; i < stringList.Count; i++)
            {
                string txt = stringList[i];
                int[] asciiArray = txt.Select(r => (int)r).ToArray();
                sum = sum + asciiArray.Sum();
            }
            sum = sum / stringList.Count;

           
            Console.WriteLine(string.Join($"{(char)sum}", stringList));
        }
    }
}
