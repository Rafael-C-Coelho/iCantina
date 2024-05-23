using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.models
{
    public class Reservation
    {
        public Client client { get; set; } //TODO Foreign key
        public DateTime date = DateTime.Now;
        public Dish dish { get; set; }
        public Extras extas { get; set; }
        public ICollection<Dish> dishes { get; set; }
        public ICollection<Extras> extras { get; set; }
        public ICollection<MenusCantina> menu { get; set; }
        public Mult mult { get; set; }
    }
}
