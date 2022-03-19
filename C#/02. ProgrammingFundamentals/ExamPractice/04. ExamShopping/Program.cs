using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExamShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }).ToList();

            var shoppingList = new Dictionary<string, int>();

            while (input[0] != "shopping")
            {
                if (shoppingList.ContainsKey(input[1]))
                {
                    shoppingList[input[1]] = shoppingList[input[1]] + int.Parse(input[2]);
                }
                else
                {
                    shoppingList[input[1]] = int.Parse(input[2]);
                }
                input = Console.ReadLine().Split(new[] { ' ' }).ToList();
            }

            while (input[0] != "exam")
            {
                if (shoppingList.ContainsKey(input[1]))
                {
                    shoppingList[input[1]] = shoppingList[input[1]] - int.Parse(input[2]);
                    if (shoppingList[input[1]] <= 0)
                    {
                        shoppingList.Remove(input[1]);
                    }
                }
                else
                {
                    Console.WriteLine(input[1] + " doesont't exist");
                }
                input = Console.ReadLine().Split(new[] { ' ' }).ToList();
            }

            foreach (var item in shoppingList)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
