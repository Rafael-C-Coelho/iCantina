using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class Extras
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public ICollection<Extras> reservations { get; set; }
        public bool Active { get; set; }
        public Extras()
        {
        }

        public Extras(string description, double price, bool isActive)
        {
            Description = description;
            Price = price;
            Active = isActive;
        }
    }
}
