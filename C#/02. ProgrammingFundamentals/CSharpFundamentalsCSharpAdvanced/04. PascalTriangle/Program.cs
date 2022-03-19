using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = int.Parse(Console.ReadLine());
           // int currentWidth = 1;
            int[][] triangle = new int[height][];

            for (int currentHeight = 0; currentHeight < height; currentHeight++)
            {
                triangle[currentHeight] = new int[currentHeight + 1];
                triangle[currentHeight][0] = 1;
                triangle[currentHeight][currentHeight] = 1;
               // currentWidth++;
                if(currentHeight >= 2)
                {
                    for (int widthCounter = 1; widthCounter < currentHeight; widthCounter++)
                    {
                        triangle[currentHeight][widthCounter] = 
                            triangle[currentHeight - 1][widthCounter - 1] +
                            triangle[currentHeight - 1][widthCounter];
                    }
                }
            }

            for (int rows = 0; rows < triangle.Length; rows++)
            {
                for (int col = 0; col < triangle[rows].Length; col++)
                {
                    Console.Write(triangle[rows][col] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
