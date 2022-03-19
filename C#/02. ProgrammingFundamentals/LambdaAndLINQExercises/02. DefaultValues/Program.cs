using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DefaultValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var kvp = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }
                , StringSplitOptions
                .RemoveEmptyEntries);

            var userRecords = new Dictionary<string, string>();

            while (kvp[0] != "end")
            {               
                var name = kvp[0];
                var number = kvp[1];

                if (!userRecords.ContainsKey(name))
                {
                    userRecords.Add(name, number);
                }

                kvp = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }
                , StringSplitOptions
                .RemoveEmptyEntries);
            }

            var defaultValue = Console.ReadLine();
            var newDictionary = new Dictionary<string, string>();

            foreach (var item in userRecords)
            {
                if(item.Value == "null")
                {
                    newDictionary.Add(item.Key, defaultValue);
                }
                else
                {
                    newDictionary.Add(item.Key, item.Value);
                }
            }
            var op = newDictionary.Where(n => n.Value != defaultValue).OrderByDescending(st => st.Key);
            var zop = newDictionary.Where(n => n.Value == defaultValue);
            var sortetOp = op.OrderByDescending(b => b.Value.Length);
            var opZop = sortetOp.Concat(zop);
     
            foreach (var item in opZop)
            {
                Console.WriteLine(item.Key + " <-> " + item.Value);
            }
        }
    }
}
