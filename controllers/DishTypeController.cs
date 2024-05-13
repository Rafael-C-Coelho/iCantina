using iCantina.helpers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.controllers
{
    public class DishTypeController : Controller
    {
        public DishTypeController() : base() {}

        public bool CreateDish(DishTypeEnum dishType, string description, bool isActive)
        {
            try { 
                Dish dish = new Dish();
                dish.Active = isActive;
                dish.Description = description;
                dish.Type = dishType;
                base.context.Dishes.Add(dish);

                return true;
            } catch (Exception)
            {
                return false;
            }
        }
    }
}
