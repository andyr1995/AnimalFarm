using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
        public class Eagle : Bird, Flying
        {
        ////////////////////////////Attributes/////////////////





        ////////////////////////////Constructors/////////////////////////

        public Eagle(String Name, int Age, String Species) : base(Name, Age, Species)
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Species);
        }

        public Eagle(int Age) : this("Name", Age, "Species")
        {

        }

        public Eagle() : this(0)
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

            public void averageAgeOfDeath()
            {
                throw new NotImplementedException();
            }
        }
}

