using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RabbitHole
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Console.ReadLine().Split(new[] { ' ' }).ToList();
            var totalEnergy = int.Parse(Console.ReadLine());
            var position = 0;
            //bool bombed = false;

            while(true)
            {
                var tokens = path[position].Split( '|' );            
                switch (tokens[0])
                {
                    case "Right":
                        position = (position + int.Parse(tokens[1])) % path.Count;
                        totalEnergy = totalEnergy - int.Parse(tokens[1]);
                        break;
                    case "Left":
                        position = Math.Abs(position - int.Parse(tokens[1])) % path.Count;
                        totalEnergy = totalEnergy - int.Parse(tokens[1]);
                        break;
                    case "Bomb":                        
                        totalEnergy = totalEnergy - int.Parse(tokens[1]);
                        if(totalEnergy <= 0)
                        {
                            Console.WriteLine("You are dead due to bomb explosion!");
                            return;
                        }
                        position = 0;
                        path.RemoveAt(position);                         
                        break;
                    case "RabbitHole":
                        Console.WriteLine("You have 5 years to save Kennedy!");                                        
                        return;                      

                }

                if (totalEnergy <= 0)
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");
                    return;
                }
                if ("rabbitHole" == path[path.Count - 1])
                {
                    path.Add("Bomb|" + totalEnergy);
                }
                else
                {
                    path.RemoveAt(path.Count - 1);
                    path.Add("Bomb|" + totalEnergy);
                }

            }
        }
    }
}
