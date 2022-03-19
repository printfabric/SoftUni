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
            double points = double.Parse(Console.ReadLine());
            double bonusPoints = 0;


            if (points % 2 == 0)
                if (points > 0 && points <= 100)
                {
                    bonusPoints = 5;
                }

                else if (points > 100 && points <= 1000)
                {
                    bonusPoints = (double)(points * 0.2);
                }

                else
                {
                    bonusPoints = (double)(points * 0.1);
                }

            if (points % 2 == 1)
                if (points > 0 && points <= 100)
                {
                    bonusPoints = 5;
                }

                else if (points > 100 && points <= 1000)
                {
                    bonusPoints = (double)(points * 0.2);
                }

                else
                {
                    bonusPoints = (double)(points * 0.1);
                }


            if (points % 2 == 0)
            {
                bonusPoints += 1;
            }

            if (points % 10 == 5)
            {
                bonusPoints += 2;
            }
            if (points == 0)
            {
                bonusPoints = 6;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(bonusPoints + points);



        }
    }
}
