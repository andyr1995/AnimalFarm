using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public abstract class Fish : Animal
        {
        ////////////////////////////Attributes




        ////////////////////////////Constructors/////////////////////////
        public Fish() : base("Default", 1, "Default")
        {

        }

        public Fish(String Name, int Age, String Species) : base(Name, Age, Species)
        {

        }

        ///////////////////////////Methods///////////////////////////////

        public override void Respire()
            {
                // implement breathe method
            }

            public override Fish reproduce(Animal otherParent)
            {
                return null;
            }

        }
}
