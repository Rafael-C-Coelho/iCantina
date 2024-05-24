using iCantina.helpers;
using iCantina.models;
using System;

namespace iCantina.controllers
{
  public class DishDetailsController : Controller
  {
    public DishDetailsController() : base()
    {
      Console.WriteLine("Create dish controller initialized.");
    }

    public bool CreateDish(string name, string description, DishTypeEnum type, bool isActive)
    {
      try
      {
        Dish dish = new Dish();
        dish.Name = name;
        dish.Description = description;
        dish.Type = type;
        dish.Active = isActive;
        context.Dishes.Add(dish);
        context.SaveChanges();
        return true;
      } catch (Exception e)
      {
        Console.WriteLine(e.Message);
        return false;
      } 
    }

    public bool UpdateDish(int id, string name, string description, DishTypeEnum type, bool isActive)
    {
      try
      {
        Dish dish = context.Dishes.Find(id);
        dish.Description = description;
        dish.Type = type;
        dish.Name = name;
        dish.Active = isActive;
        context.SaveChanges();
        return true;
      } catch (Exception e)
      {
        Console.WriteLine(e.Message);
        return false;
      }
    }

    public bool DeleteDish(int id)
    {
      try
      {
        Dish dish = context.Dishes.Find(id);
        context.Dishes.Remove(dish);
        context.SaveChanges();
        return true;
      } catch (Exception e)
      {
        Console.WriteLine(e.Message);
        return false;
      }
    }
  }
}
