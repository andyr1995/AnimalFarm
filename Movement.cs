using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public interface Movement
    {
        public interface Walking
        {
            public void moveForward();
            public void moveBackwards();
            public void moveRight();
            public void moveLeft();
        }
    }
}
