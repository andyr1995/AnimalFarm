using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    internal class Movement
    {
        public interface Walking
        {
            public void MoveForward();
            public void MoveBackwards();
            public void MoveRight();
            public void MoveLeft();
        }
    }
}
