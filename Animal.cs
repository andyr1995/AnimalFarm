using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public abstract class Animal
    {
        ///////////////////////////////////Attributes////////////////////////////

        public int Age { get; private set; }
        public string Name { get; set; }






        /////////////////////////////////Constructors///////////////////////////////
        public Animal()
            : base()
        {
            Age = 1;
            Name = "bob";
        }





        ////////////////////////////////////////////////Methods///////////////////////////////////////
        public abstract void eat(String food);

        public void sleep(int lengthOfSleep)
        {
            // sleep method
        }

        public abstract Animal reproduce(Animal otherParent);


        public abstract void Respire();

        public String Poo()
        {
            return "I defecate";
        }
   

        public void die(int averageAgeOfDeath)
        {
            if (averageAgeOfDeath >= 60)
            {
                Console.WriteLine("It's a long life!");
            }
            else if (averageAgeOfDeath >= 20)
            {
                Console.WriteLine("I am neither old nor young");
            }
            else
            {
                Console.WriteLine("My life is fleeting :(");
            }
        }

    }
}
