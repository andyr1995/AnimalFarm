using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public abstract class Mammal : Animal
    {
        ////////////////////////////Attributes




        ////////////////////////////Constructors/////////////////////////
        public Mammal() : base("Default" ,1, "Default")
        {

        }

        public Mammal(String Name, int Age, String Species) : base(Name, Age, Species)
        {

        }

        ///////////////////////////Methods///////////////////////////////
        
        public override void Respire()
        {
            // implement breathe method
        }

        public override Mammal reproduce(Animal otherParent)
        {
            return null; 
        }

    }
}
