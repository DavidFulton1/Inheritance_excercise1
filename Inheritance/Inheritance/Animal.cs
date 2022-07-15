using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
       public Animal()
        {
        }
         public int Weight { get; set; }
        public string Species { get; set; }
         public bool IsAlive { get; set; }  
        public bool HasTeeth { get; set; }

    }
}
