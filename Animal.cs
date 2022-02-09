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
        private int age;
        private string name;
        public int Age { get; set; }






        /////////////////////////////////Constructors///////////////////////////////
        public Animal()
            : base()
        {
            age = 1;
            name = "bob";
        }





        ////////////////////////////////////////////////Methods///////////////////////////////////////
        public abstract void eat(String food);

        public void sleep(int lengthOfSleep)
        {
           // sleep method
        }

        public abstract Animal reproduce(Animal otherParent);


        public abstract void breathe();

        public String poo()
        {
            Age = 16;
            return "I have logged this";
            
        }

        public void die()
        {
            // add die method
        }

    }
}
