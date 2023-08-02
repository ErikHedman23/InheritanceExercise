using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public string Species { get; set; }
        public string Color { get; set; }
        public string DietConsists { get; set; }
        public decimal WingSpan { get; set; }
    }
}
