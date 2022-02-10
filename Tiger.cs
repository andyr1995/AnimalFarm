using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public class Tiger : Mammal, Flying, Swimming
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
            Console.WriteLine("i am flying");
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
            Console.WriteLine("Oops im a tiger so i cant fly");

        }

        public void swimming()
        {
            Console.WriteLine("Swimming's Grrrrrrrreat!");
        }

        public void Diving()
        {
            Console.WriteLine("I can dive from 50m!");
        }

        public void Jumping()
        {
            Console.WriteLine("Tony leaps from the water!");
        }

        public void Drowning()
        {
            Console.WriteLine("Oops Tony drowned");
        }
    }
}
