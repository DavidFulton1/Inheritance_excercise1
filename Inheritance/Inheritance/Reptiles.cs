using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptiles : Animal
    { public Reptiles() { }
    
    public int NumberOfLegs { get; set; }
    public string ScaleColor { get; set; }
    public int Length { get; set; }
    public bool IsDinosaur { get; set; }
    
    }
}

