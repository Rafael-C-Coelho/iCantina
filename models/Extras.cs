using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class Extras
    {
        public string Description { get; set; }
        public double Price { get; set; }

        public Extras()
        {
        }

        public Extras(string description, double price)
        {
            Description = description;
            Price = price;
        }
    }
}
