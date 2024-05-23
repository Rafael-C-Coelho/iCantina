using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iCantina.models
{
  public class Extras
  {
    [Key]
    public int Id { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public bool Active { get; set; }
    public Extras()
    {
    }

    public Extras(string description, double price, bool isActive) : this()
    {
      Description = description;
      Price = price;
      Active = isActive;
    }
  }
}
