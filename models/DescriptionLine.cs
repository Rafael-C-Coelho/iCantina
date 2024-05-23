using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class DescriptionLine
    {
        [key] 

        public string Name { get; set; }
        public string Description { get; set; }

        public DescriptionLine()
        {
        }

        public DescriptionLine(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }

   

    
}
