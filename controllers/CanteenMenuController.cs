using iCantina.helpers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace iCantina.controllers
{
  public class CanteenMenuController : Controller
  {
    public CanteenMenuController() : base()
    {
      Console.WriteLine("Canteen Menu controller initialized.");
    }

    public List<Dish> GetDishesByType(DishTypeEnum type)
    {
      if (type == DishTypeEnum.Meat)
      {
        return context.Dishes.Where(dish => dish.Type == DishTypeEnum.Meat).ToList();
      }
      else if (type == DishTypeEnum.Vegetarian)
      {
        return context.Dishes.Where(dish => dish.Type == DishTypeEnum.Vegetarian).ToList();
      }
      else if (type == DishTypeEnum.Fish)
      {
        return context.Dishes.Where(dish => dish.Type == DishTypeEnum.Fish).ToList();
      }
      else
      {
        return new List<Dish>();
      }
    }

    internal object GetExtras()
    {
      return context.Extras.ToList();
    }
  }
}
