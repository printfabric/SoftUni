using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Exercises
{
    public class SetsAndDictionariesEx
    {
        public static void Main(string[] args)
        {

            var dict = new Dictionary<string, int>();

            dict["one"] = 1;
            dict["two"] = 2;
            dict["three"] = 3;
            dict["four"] = 4;
            
            var sumD = dict.Sum(x => x.Value);

            Console.WriteLine(sumD);

        }
    }
}
