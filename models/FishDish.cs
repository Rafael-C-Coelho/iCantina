using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class FishDish : CreateDish
    {
    
        public FishDish()
        {
        }

        public FishDish(string name) : base(name) { }

        public string Name { get; set; }
    }
}
