using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public string Species { get; set; }
        public string DietConsists { get; set; }
        public string ColdBloodedOrWarmBlooded {get; set; }
        public  bool CanCamoflouge { get; set; }
    }
}
