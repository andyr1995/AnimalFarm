using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public abstract class Reptile : Animal
    {
        ////////////////////////////Attributes




        ////////////////////////////Constructors/////////////////////////
        public Reptile() : base("Default", 1, "default")
        {

        }

        public Reptile(String Name, int Age, String Species) : base(Name, Age, Species)
        {

        }

        ///////////////////////////Methods///////////////////////////////

        public override void Respire()
        {
            // implement breathe method
        }

        public override Reptile reproduce(Animal otherParent)
        {
            return null;
        }

    }
}
