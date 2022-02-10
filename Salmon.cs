﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public class Salmon : Fish , Swimming  
    {
        ////////////////////////////Attributes/////////////////





        ////////////////////////////Constructors/////////////////////////

        public Salmon(String Name, int Age, String Species) : base(Name, Age, Species)
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Species);
        }

        public Salmon(int Age) : this("Name", Age, "Species")
        {

        }

        public Salmon() : this(0)
        {

        }



        ///////////////////////////Methods///////////////////////////////
        public override void eat(string food)
        {
            // implement this later
        }


        public void swimming()
        {
            Console.WriteLine("Swimming is what i do");
        }

        public void Diving()
        {
            Console.WriteLine("I cannot dive deep");
        }

        public void Jumping()
        {
            Console.WriteLine("However I can leap from the water!");
        }

        public void Drowning()
        {
            Console.WriteLine("I cannot drown, I am a fish");
        }


    } 




}

