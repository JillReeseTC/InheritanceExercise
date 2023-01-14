using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {

        public Bird()
        {
            
        }

        public string MovementType { get; set; }
        public int Legs { get; set; }
        public string SkinType { get; set; }
        public bool HasWings { get; set; }


    }
}
