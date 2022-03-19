using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Traversal_Method_in_the_IOManager
{
    class Program
    {
        static void Main(string[] args)
        {
            IOManager.ChangeCurrentDirecoryAbsolute(@"C:\windows");
            IOManager.TraverseDirectory(20);
        }
    }
}
