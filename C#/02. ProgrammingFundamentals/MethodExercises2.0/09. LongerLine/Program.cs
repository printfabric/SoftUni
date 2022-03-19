using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLineX1 = double.Parse(Console.ReadLine());
            var firstLineY1 = double.Parse(Console.ReadLine());
            var firstLineX2 = double.Parse(Console.ReadLine());
            var firstLineY2 = double.Parse(Console.ReadLine());
            var secondLineX1 = double.Parse(Console.ReadLine());
            var secondLineY1 = double.Parse(Console.ReadLine());
            var secondLineX2 = double.Parse(Console.ReadLine());
            var secondLineY2 = double.Parse(Console.ReadLine());

            GetLongestLine(firstLineX1, firstLineY1, firstLineX2, firstLineY2,
                       secondLineX1, secondLineY1, secondLineX2, secondLineY2);


            //GetClosesPointToCenter(firstLineX1, firstLineY1,
            //                   firstLineX2, firstLineY2);
        }

        static void GetLongestLine(double firstLineX1, double firstLineY1,
                                   double firstLineX2, double firstLineY2,
                                  double secondLineX1, double secondLineY1,
                                  double secondLineX2, double secondLineY2)
        {
            var firstLine = Math.Abs(firstLineX1) + Math.Abs(firstLineY1) +
                            Math.Abs(firstLineX2) + Math.Abs(firstLineY2);
            var secondLine = Math.Abs(secondLineX1) + Math.Abs(secondLineY1) +
                             Math.Abs(secondLineX2) + Math.Abs(secondLineY2);

            var firstPointFirstLine = Math.Abs(firstLineX1) + Math.Abs(firstLineY1);
            var secondPointFirstLine = Math.Abs(firstLineX2) + Math.Abs(firstLineY2);
            var firstPointSecondLine = Math.Abs(firstLineX1) + Math.Abs(firstLineY1);
            var secondPointSecondLine = Math.Abs(firstLineX2) + Math.Abs(firstLineY2);

            if (firstLine > secondLine)
            {
                if (firstPointFirstLine < secondPointFirstLine)
                {
                    Console.Write("({0}, {1})", firstLineX1, firstLineY1);
                    Console.Write("({0}, {1})", firstLineX2, firstLineY2);
                }
                else if (firstPointFirstLine == secondPointFirstLine)
                {
                    Console.Write("({0}, {1})", firstLineX1, firstLineY1);                    
                }

                else
                {
                    Console.Write("({0}, {1})", firstLineX2, firstLineY2);
                    Console.Write("({0}, {1})", firstLineX1, firstLineY1);
                }

            }
            

            else
            {
                if (firstPointSecondLine < secondPointSecondLine)
                {
                    Console.Write("({0}, {1})", secondLineX1, secondLineY1);
                    Console.Write("({0}, {1})", secondLineX2, secondLineY2);
                }
                else if (firstPointSecondLine == secondPointSecondLine)
                {
                    Console.Write("({0}, {1})", secondLineX1, secondLineY1);
                }
                else
                {
                    Console.Write("({0}, {1})", secondLineX2, secondLineY2);
                    Console.Write("({0}, {1})", secondLineX1, secondLineY1);
                }
            }



            //GetMax(firstLine, secondLine);
            //Console.WriteLine(GetMax(firstLine, secondLine));

        }


        //     static double GetMax(double firstLine, double secondLine)
        //    {
        //        return firstLine > secondLine ?  firstLine : secondLine;
        //    }
        //}

        //static void GetClosesPointToCenter(double x1, double y1,
        //                                   double x2, double y2)
        //{
        //    var firstPoint = Math.Abs(x1) + Math.Abs(y1);
        //    var secondPoint = Math.Abs(x2) + Math.Abs(y2);

        //    if (firstPoint < secondPoint)
        //    {
        //        Console.Write("({0}, {1})", x1, y1);
        //    }
        //    else if (firstPoint == secondPoint)
        //    {
        //        Console.Write("({0}, {1})", x1, y1);

        //    }
        //    else
        //    {
        //        Console.Write("({0}, {1})", x2, y2);

        //    }
        //}
    }
}


