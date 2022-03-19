using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<string>();
            nums.Add("fasfas");
            nums.Add("sgvsd");
            nums.Remove("sgvsd");
            //nums.Add(30);

            Console.WriteLine(String.Join(", ", nums));
        }
    }
}
