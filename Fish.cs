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
