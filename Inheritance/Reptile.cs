using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {

        public Reptile()
        {
           
        }

        public string Name { get; set; }    
        public string MovementType { get; set; } = "crawls";
        public int Legs { get; set; } = 4;
        public string SkinType { get; set; } = "scales";
        public bool LivesInWater { get; set; } = true;


    }
}
