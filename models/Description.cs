using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class Description
    {
        [key]
        public string Name { get; set; }
        public ICollection<DescriptionLine> DescriptionLines { get; set; }

        public Description()
        {
            DescriptionLines = new List<DescriptionLine>();
        }

        public Description(string name)
        {
            DescriptionLines = new List<DescriptionLine>();
        }
    }

    
}
