using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.UnunionLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var primalList = Console.ReadLine().
            Split(new[] { ' ' }).Select(int.Parse).ToList();

            var n = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = 0; i < n; i++)
            {
                var nList = Console.ReadLine().Split(new[] { ' ' }).
                Select(int.Parse).ToList();

                for (int j = 0; j < nList.Count; j++)
                {
                    for (int k = 0; k <= primalList.Count -1; k++)
                    {
                        if (nList[j] == primalList[k])
                        {
                            primalList.RemoveAt(k);
                            counter--;
                            k--;
                        }
                        else
                        {
                            counter++;
                            if(counter == (primalList.Count))
                            {
                                primalList.Add(nList[j]);
                                k++;
                            }
                        }

                    }

                    counter = 0;
                }
                
            }

            primalList.Sort();
            for (int i = 0; i < primalList.Count; i++)
            {
                Console.Write(primalList[i] + " ");
            }
        }
    }
}
