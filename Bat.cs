using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public class Bat : Mammal , Flying
    {
        ////////////////////////////Attributes/////////////////





        ////////////////////////////Constructors/////////////////////////
        public Bat(String Name, int Age, String Species) : base (Name, Age, Species)
        {
           
        }

        public Bat(int Age) : this("Name", Age, "Species")
        {

        }

        public Bat():this(0)
        {

        }




        ///////////////////////////Methods///////////////////////////////
        public override void eat(string food)
        {
            // implement this later
        }

        public void flight()
        {
            Console.WriteLine("I am flying");
        }

        public void landing()
        {
            throw new NotImplementedException();
        }

        public void takeOff()
        {
            throw new NotImplementedException();
        }

        public void crashing()
        {
            Console.WriteLine("Oops i crashed like a stupid nocturnal animal");
        }
    }
}
