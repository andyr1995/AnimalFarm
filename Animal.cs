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

        public int Age { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }






        /////////////////////////////////Constructors///////////////////////////////
       
        public Animal(String Name, int Age, String Species)
        {
            this.Name = Name;
            this.Age = Age;
            this.Species = Species;


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

            if (averageAgeOfDeath >= 100)
            { 
                Console.WriteLine("When will it end");
            }

            else if (averageAgeOfDeath <100 && averageAgeOfDeath >20)
            {
                Console.WriteLine("It's a long life!");
            }

            else if (averageAgeOfDeath <=20 && averageAgeOfDeath >10)
            {
                Console.WriteLine("I am neither old nor young");
            }

            else if (averageAgeOfDeath <= 10)
            {
                Console.WriteLine("My life is fleeting :(");
            }

        }

    }
}
