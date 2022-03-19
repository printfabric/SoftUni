using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10.Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var secInput = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < secInput.Length; i++)
            {
                if (secInput[i] == '(')
                {
                    stack.Push(i);
                }
                else if (secInput[i] == ')')
                {
                    var subStr = secInput.Substring(stack.Peek(),  i - stack.Pop() + 1);
                    Console.WriteLine(subStr);
                }
            }
        }
    }
}
