using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public class Tortoise : Reptile, Flying
    {
        ////////////////////////////Attributes/////////////////





        ////////////////////////////Constructors/////////////////////////

        public Tortoise(String Name, int Age, String Species) : base(Name, Age, Species)
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Species);
        }

        public Tortoise(int Age) : this("Jonathan", Age, "Seychelles giant tortoise")
        {

        }

        public Tortoise() : this(0)
        {

        }



        ///////////////////////////Methods///////////////////////////////
        public override void eat(string food)
        {
            // implement this later
        }

        public void flight()
        {
            Console.WriteLine("i am soaring like an Eagle!");
        }
        public void takeOff()
        {
            throw new NotImplementedException();
        }

        public void landing()
        {
            throw new NotImplementedException();
        }


        public void crashing()
        {
            Console.WriteLine("I am a proud creature and do not crash!");
        }
        public void moveForward()
        {
            Console.WriteLine("Slowly but surely I move forward");
        }

        public void moveBackwards()
        {
            Console.WriteLine("I don't have time to go back");
        }

        public void averageAgeOfDeath()
        {
            throw new NotImplementedException();
        }
    }
}
