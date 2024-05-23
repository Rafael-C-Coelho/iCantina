using iCantina.models;
using iCantina.views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina
{
    public class iCantinaContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceLine> InvoiceLines { get; set; }

        public DbSet<CreateDish> Dishes { get; set; }   

        public DbSet <MeatDish> MeatDishes { get; set; }
        public DbSet <FishDish> FishDishes { get; set;}
        public DbSet <VegetarianDish> VegetarianDishes { get; set; }

        public DbSet <Description> Descriptions { get; set; }
        public DbSet <DescriptionLine> DescriptionLines { get; set; }


    }
}
