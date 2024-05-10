using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class Dish 
    {
        public string Meat {  get; set; } 
        public string Fish { get; set; } 
        public string Vegetarian { get; set; }

        public ICollection<Dish> reservations { get; set; }


        public Dish()
        {
            reservations = new List<Dish>();
        }

        public Dish(string meat, string fish, string vegetarian)
        {
            meat = Meat; 
            fish = Fish;
            vegetarian = Vegetarian;
            reservations = new List<Dish>();
        }

    }


}
