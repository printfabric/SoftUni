using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleJudge
{
    class Tester
    {
        public static void CompareContent(string userOutputPath, string expectedoutputPath)
        {
            OutputWriter.WriteMessageOnNewLine("Reading files...");
            string mismatchPath = GetMismatchPath(expectedoutputPath);


        }

        private static string GetMismatchPath(string expectedOutputPath)
        {
            int indexOf = expectedOutputPath.LastIndexOf('\\');
            string directoryPath = expectedOutputPath.Substring(0, indexOf);
            string finalPath = directoryPath = directoryPath + @"\Mismatches.txt";
            return finalPath;
        }

    }
}

