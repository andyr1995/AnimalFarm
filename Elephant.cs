﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public class Elephant : Mammal , Flying
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
            Console.WriteLine("Oops i crashed because elephants arent supposed to fly");
        }

        public void averageAgeOfDeath()
        {
            throw new NotImplementedException();
        }
    }
}

