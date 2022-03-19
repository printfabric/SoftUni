using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.OrderedBankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { "->", " " }
                , StringSplitOptions
                .RemoveEmptyEntries);

            var customersInformation = new SortedDictionary<string, Dictionary<string, decimal>>();

            while (input[0] != "end")
            {
                var bank = input[0];
                var account = input[1];
                var balance = decimal.Parse(input[2]);

                if (!customersInformation.ContainsKey(bank))
                {
                    customersInformation.Add(bank, new Dictionary<string, decimal>());
                }

                if (!customersInformation[bank].ContainsKey(account))
                {
                    customersInformation[bank].Add(account, 0);
                }

                customersInformation[bank][account] += balance ;

                input = Console.ReadLine()
                .Split(new[] { "->", " " }
                , StringSplitOptions
                .RemoveEmptyEntries);
            }

            foreach (var bankData in customersInformation)
            {
                string bank = bankData.Key;
                Dictionary<string, decimal> accountsData = bankData.Value;
                foreach (var accountData in accountsData)
                {
                    string account = accountData.Key;
                    decimal balance = accountData.Value;

                    Console.WriteLine("{0} -> {1} ({2})", account, balance, bank);
                }

            }

        }
    }
}


//Dictionary<string, Dictionary<string, decimal>> orderedDictionary =
//        customersInformation
//        .OrderByDescending(x => x.Key)
//        .ToDictionary(x => x.Key, x => x.Value);

//foreach (var customer in customersInformation.OrderByDescending(key => key.Value))
//{
//    foreach (var info in customer.Value)
//    {
//        Console.Write(info.Key + " -> ");
//        Console.WriteLine(info.Value + " (" + customer.Key + ")");
//    }
//}

//foreach (var customer in customersInformation)
//{
//    foreach (var info in customer.Value)
//    {
//        Console.Write(info.Key + " -> ");
//        Console.WriteLine(info.Value + " (" + customer.Key + ")");
//    }
//}