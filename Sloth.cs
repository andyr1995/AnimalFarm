using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public class Sloth : Mammal, Swimming, Movement
    {
        ////////////////////////////Attributes/////////////////





        ////////////////////////////Constructors/////////////////////////

        public Sloth(String Name, int Age, String Species) : base(Name, Age, Species)
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Species);
        }

        public Sloth(int Age) : this("Name", Age, "Species")
        {

        }

        public Sloth() : this(0)
        {

        }



        ///////////////////////////Methods///////////////////////////////
        public override void eat(string food)
        {
            // implement this later
        }
        public void swimming()
        {
            Console.WriteLine("Swimming is not something i'm good at");
        }

        public void Diving()
        {
            Console.WriteLine("I cannot dive");
        }

        public void Jumping()
        {
            Console.WriteLine("I cannot leap from the water");
        }

        public void Drowning()
        {
            Console.WriteLine("I drown in puddles");
        }
        public void moveForward()
        {
            Console.WriteLine("Slowly but surely I move forward");
        }

        public void moveBackwards()
        {
            Console.WriteLine("I don't have time to go back");
        }

        public void moveLeft()
        {
            Console.WriteLine("I dwill turn to the left ");
        }

        public void moveRight()
        {
            Console.WriteLine("I will now turn to the right ");
        }
    }
}
