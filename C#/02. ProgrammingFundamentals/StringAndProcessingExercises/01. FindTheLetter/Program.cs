using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FindTheLetter
{
    class Program
    {
        static void Main(string[] args)
        {
      
            var str = Console.ReadLine();
            var word = Console.ReadLine();
            var arr = word.Split(' ').ToArray();
            var x = 0;
            var number = int.TryParse(arr[1], out x);
            var counter = 0;
            var pos = -1;

            for (int i = 0; i < x; i++)
            {
                counter++;
                 pos = str.IndexOf(word[0], pos +1);
                //pos = pos - 1;   
            }

            char[] charArr;
            charArr = word.ToCharArray(0, 1);
            if (str[Math.Abs(pos)] == charArr[0])
            {
                Console.WriteLine(pos);
            }
            else
            {
                Console.WriteLine("Find the letter yourself!");
            }
        }
    }
}
