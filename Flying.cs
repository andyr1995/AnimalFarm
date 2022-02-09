using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public interface Flying
    {
        public void takeOff();
        public void flight();
        public void landing();
        public void crashing();
    }
}
