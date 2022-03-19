using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cats
{
    public class cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public string SayHello()
        {
            return $"Hi, I am {Name}! I am {Age} years old.";
        }
    }
}
