using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleJudge
{
   public static class Program
    {
       public static void Main(string[] args)
        {
            //IOManager.TraverseDirectory(@"C:\Users\Ivan\Documents\Visual Studio 2015");

            //Tester.CompareContent(@"F:\copySSD\Users\IvanIvan\Desktop\programing\C#\03. C# Fundamentals\C# Advanced 2.0\07. Files and Directories\BashSoft-FirstWeek\test1.txt",
            //  @"F:\copySSD\Users\IvanIvan\Desktop\programing\C#\03. C# Fundamentals\C# Advanced 2.0\07. Files and Directories\BashSoft-FirstWeek\test3.txt");
            //IOManager.ChangeCurrentDirectoryAbsolute(@"C:\Windows");
            //IOManager.TraverseDirectory(20);
            //IOManager.CreateDirectoryInCurrentFolder("*2");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
        }
    }
}
