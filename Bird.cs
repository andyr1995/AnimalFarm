using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
   
        public abstract class Bird : Animal
        {
            ////////////////////////////Attributes




            ////////////////////////////Constructors/////////////////////////


            ///////////////////////////Methods///////////////////////////////

            public override void Respire()
            {
                // implement breathe method
            }

            public override Bird reproduce(Animal otherParent)
            {
                return null;
            }

        }
}

