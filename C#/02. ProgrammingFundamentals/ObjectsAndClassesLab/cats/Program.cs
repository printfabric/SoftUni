using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cats
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCat = new cat();  
            var secondCat = new cat();
            var thirdCat = new cat();

            firstCat.Name = "Pesho";
            secondCat.Name = "Gosho";
            thirdCat.Name = "Penka";

            firstCat.Age = 1;
            secondCat.Age = 2;
            thirdCat.Age = 3;

            firstCat.Color = "black";
            secondCat.Color = "white";
            thirdCat.Color = "grey";

            var fourthCat = new cat
            {
                Name = "Ivan",
                Age = 1,
                Color = "Mixed"
            };

            //Console.WriteLine(firstCat.Age);
            //Console.WriteLine(secondCat.Age);
            //Console.WriteLine(secondCat.Color);

            var greeting = fourthCat.SayHello();
            //Console.WriteLine(greeting);

            var dog = new dog
            {
                Name = "Sharo",
                Breed = "Street",
                Color = "Mixed",
                isAsleep = false, hasEaten = false
            };
            dog.eat(firstCat);
            dog.goToSleep();
            Console.WriteLine(dog.isAsleep);
        }
    }
} 
 