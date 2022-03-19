using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace _01.RegisteredUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var userList = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }
                , StringSplitOptions
                .RemoveEmptyEntries);

            var userRecords = new Dictionary<string, DateTime>();

           
        }
    }
}
