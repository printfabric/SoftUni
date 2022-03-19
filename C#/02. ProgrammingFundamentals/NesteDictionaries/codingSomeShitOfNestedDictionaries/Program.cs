using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingSomeShitOfNestedDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var telephoneBook = new Dictionary<string, List<int>>();

            telephoneBook.Add("Pesho", new List<int> { 12345, 3 });
            telephoneBook.Add("Acho", new List<int> { 12345, 3 });

            foreach (var record in telephoneBook)
            {
                string name = record.Key;
                List<int> numbers = record.Value;

                Console.WriteLine("{0}: {1}", name, string.Join(" ", numbers));
            }
        }
    }
}
