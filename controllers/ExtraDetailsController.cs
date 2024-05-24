using System;

namespace iCantina.controllers
{
  public class ExtraDetailsController : Controller
  {
    public ExtraDetailsController() : base() { }

    public bool CreateExtras(string description, double price, bool active)
    {
      try
      {
        models.Extra extra = new models.Extra();
        extra.Description = description;
        extra.Price = price;
        extra.Active = active;
        base.context.Extras.Add(extra);
        base.context.SaveChanges();

        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public bool UpdateExtras(int id, string description, double price, bool active)
    {
      try
      {
        models.Extra extra = base.context.Extras.Find(id);
        extra.Description = description;
        extra.Price = price;
        extra.Active = active;
        base.context.SaveChanges();

        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public bool DeleteExtras(int id)
    {
      try
      {
        models.Extra extra = base.context.Extras.Find(id);
        base.context.Extras.Remove(extra);
        base.context.SaveChanges();

        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }
  }
}
