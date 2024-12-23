using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
  public class Menu
  {
    [Key]
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public ICollection<Dish> Dishes { get; set; }
    public ICollection<Extra> Extras { get; set; }
    public int QuantityAvailable { get; set; }
    public double PriceStudent { get; set; }
    public double PriceProfessor { get; set; }

    public Menu()
    {
    }
  }
}
