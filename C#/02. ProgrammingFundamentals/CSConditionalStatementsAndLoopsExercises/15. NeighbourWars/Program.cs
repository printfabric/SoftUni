using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshosDamage = int.Parse(Console.ReadLine());
            var goshosDamage = int.Parse(Console.ReadLine());
            var peshosHealth = 100;
            var goshosHealth = 100;
            var counter = 0;
            

            for (int i = 1; i > 0; i++)
            {
                
                
                counter++;
                if (i % 2 == 0)
                {
                    peshosHealth = peshosHealth - goshosDamage;
                    if (peshosHealth <= 0)
                    {
                        
                        Console.WriteLine($"Gosho won in {counter}th round.");
                        i = -1;
                        break;
                    }
                    
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                }
                else if (i % 2 != 0)
                {
                    goshosHealth = goshosHealth - peshosDamage;
                    if (goshosHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {counter}th round.");
                        i = -1;
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                    
                }                
                
                if (counter % 3 == 0)
                {
                    peshosHealth = peshosHealth + 10;
                    goshosHealth = goshosHealth + 10;
                }
                

            }

        }
    }
}
