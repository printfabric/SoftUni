using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TimeSinceBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        var firstLatter = (char)(i + 'a');
                        var secondLatter = (char)(j + 'a');
                        var thirdLatter = (char)(k + 'a');
                        Console.WriteLine($"{firstLatter}{secondLatter}{thirdLatter}");
                    }
                }
            }
        }
    }
}
