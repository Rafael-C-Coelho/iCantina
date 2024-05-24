using iCantina.helpers;
using System.ComponentModel.DataAnnotations;

namespace iCantina.models
{
  public class Dish
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DishTypeEnum Type { get; set; }
    public bool Active { get; set; }

    public Dish()
    {
    }

    public override string ToString()
    {
      return $"Name: {Name}";
    }
  }
}
