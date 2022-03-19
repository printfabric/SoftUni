using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MirrorImage
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(new[] { ' ' })
                .ToList();
            var newList = new List<string>();

            while(true)
            {
                var index = Console.ReadLine();
                if(index == "Print")
                {
                    Console.WriteLine(string.Join(" ", list));
                    return;
                }
                else
                {
                    int x = 0;
                    int.TryParse(index, out x);
                    
                    for (int i = x - 1; i >= 0; i--)
                    {
                        newList.Add(list[i]);                        
                    }

                    newList.Add(list[x]);
                    for (int i = list.Count-1; i > x ; i--)
                    {
                        newList.Add(list[i]);                        
                    }

                    for (int i = 0; i < newList.Count; i++)
                    {
                        list.RemoveAt(0);
                        list.Add(newList[i]);
                    }

                }
            }
        }
    }
}
