using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class Reservation
    {
        public DateTime date = DateTime.Now;
        public Dish dish { get; set; }
        public Extras extas { get; set; }

    }
}
