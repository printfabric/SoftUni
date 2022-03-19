using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cats
{
    public class dog
    {
        public string Name { get; set; }
        public string Breed{ get; set; }
        public string Color { get; set; }
        public bool isAsleep{ get; set; }
        public bool hasEaten{ get; set; }

        public void goToSleep()
        {
            if(hasEaten)
            {
                isAsleep = true; 
            }
        }

        public void eat(cat cat)
        {
            if(cat != null)
            {
                hasEaten = true;
            }
        }
    }
}
