using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int bonusPoints = int.Parse(Console.ReadLine());

            if (bonusPoints > 0 && bonusPoints <= 3)
            {
                Console.WriteLine(bonusPoints * 10);
            }

            else if (bonusPoints >= 4 && bonusPoints <= 6)
            {
                Console.WriteLine(bonusPoints * 100);
            }

            else if (bonusPoints >= 7 && bonusPoints <= 9)
            {
                Console.WriteLine(bonusPoints * 1000);
            }

            else  
            {
                Console.WriteLine("error");
            }


            
                    
                    

        }
    }
}
