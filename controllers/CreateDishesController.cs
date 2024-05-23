using iCantina.models;
using iCantina.views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.controllers
{
    public class CreateDishesController : Controller 
    {
        public CreateDishesController() : base() {
            Console.WriteLine("Create dish controller initialized.");
        }

        public bool CreateMeatDish(string name)
        {
            try
            {
                MeatDish meatdish = new MeatDish();
                meatdish.Name = name;
                Console.WriteLine("Creating meat dish...");
                return true;
            }
            catch (Exception) {
                return false; 
            }
        }

        public bool CreateFishDish (string name)
        {
            try
            {
                FishDish fishdish = new FishDish();
                fishdish.Name = name;
                Console.WriteLine("Creating fish dish...");
                return true;
            }
            catch (Exception) { return false;}
        }  

        public bool CreateVegetarianDish (string name)
        {
            try
            {
                FishDish fishDish = new FishDish();
                fishDish.Name = name;
                Console.WriteLine("Creating vegetarian dish...");
                return true; 
            }
            catch(Exception) { return false;}
        }

        public bool UpdateMeat(string name)
        {
            try
            {
                MeatDish meatDish = context.MeatDishes.Find(name);
                meatDish.Name = name;
                Console.WriteLine("Updating meat dish...");
                context.SaveChanges();
                return true;
            }
            catch (Exception) 
            { 
                return false;
            }
        }

        public bool UpdateFish(string name)
        {
            FishDish fishDish = context.FishDishes.Find(name);
            fishDish.Name = name;
            Console.WriteLine("Uploading fish dish...");
            context.SaveChanges();
            return true;
        }

        public bool UpdateVegetarian(string name)
        {
            VegetarianDish vegetarianDish = context.VegetarianDishes.Find(name);
            vegetarianDish.Name = name;
            Console.WriteLine("Uploading vegetarian dish...");
            context.SaveChanges();
            return true;
        }
        public bool DeleteMeat(string name)
        {
            try
            {
                MeatDish meatDish = context.MeatDishes.Find(name);
                Console.WriteLine("Deleting meat dish...");
                context.MeatDishes.Remove(meatDish);
                context.SaveChanges();
                return true;   
            }
            catch (Exception) { 
                return false; 
            }
        }

        public bool DeleteFish(string name)
        {
            try
            {
                FishDish fishDish = context.FishDishes.Find(name);
                Console.WriteLine("Deleting fish dish...");
                context.FishDishes.Remove(fishDish);
                context.SaveChanges();
                return true;    
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteVegetarian(string name)
        {
            try
            {
                VegetarianDish vegetarianDish = context.VegetarianDishes.Find(name);
                Console.WriteLine("Deleting vegetarian dish...");
                context.VegetarianDishes.Remove(vegetarianDish);
                context.SaveChanges(); 
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<MeatDish> GetMeatDishes()
        {
            return context.MeatDishes.ToList();
        }

        public List<FishDish> GetFishDishes() 
        { 
            return context.FishDishes.ToList();
        }

        public List<VegetarianDish> GetVegetarianDish()
        {
            return context.VegetarianDishes.ToList();
        }
    }
}
