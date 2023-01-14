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

        public bool MovesIndependently {get; set; } = true;

        public bool HasEyes { get; set; } = true;
        
        public bool HasParents { get; set; } = true;

        public string SkinType { get; set; }



    }
}
