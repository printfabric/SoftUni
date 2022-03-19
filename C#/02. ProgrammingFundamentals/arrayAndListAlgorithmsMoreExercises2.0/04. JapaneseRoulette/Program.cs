using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.JapaneseRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            var bulInRevList = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToList();
            var strantOfPlayers = Console.ReadLine()
                .Split(' ')
                .ToList();
            var position = 0;
            var counter = 0;

            while (true)
            {
                var moves = strantOfPlayers[counter].Split(',');
                counter++;

                if (bulInRevList[position] == 1)
                {
                    Console.WriteLine($"Game over! Player {counter-1} is dead.");
                    return;
                }
                switch (moves[1])
                {
                    case "Right":
                        position = (position + int.Parse(moves[0])) % bulInRevList.Count;
                        if (bulInRevList[position] == 1)
                        {
                            Console.WriteLine($"Game over! Player {counter - 1} is dead.");
                            return;
                        }
                        position = (position + 1) % bulInRevList.Count;
                        break;
                    case "Left":
                        position = Math.Abs(position - int.Parse(moves[0])) % bulInRevList.Count;
                        if (bulInRevList[position] == 1)
                        {
                            Console.WriteLine($"Game over! Player {counter - 1} is dead.");
                            return;
                        }
                        position = (position + 1) % bulInRevList.Count;
                        break;
                        Console.WriteLine(position);
                }

            }
        }
    }
}
