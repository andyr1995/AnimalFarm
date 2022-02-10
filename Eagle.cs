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
                throw new NotImplementedException();
            }

            public void averageAgeOfDeath()
            {
                throw new NotImplementedException();
            }
        }
}

