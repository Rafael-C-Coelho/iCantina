using iCantina.helpers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iCantina.models
{
    public class CreateDish : Dish
    {
        public float Balance { get; set; }
        public ICollection<Description> Descriptions { get; set; }

        public CreateDish()
        {
            Descriptions = new List<Description>();
        }

        public CreateDish(string name) : base(name)
        {
            Descriptions = new List<Description>();
        }

    }
}
