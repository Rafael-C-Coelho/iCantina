using iCantina.models;
using iCantina.views;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace iCantina
{
  public class iCantinaContext : DbContext
  {
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Professor> Professors { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<InvoiceLine> InvoiceLines { get; set; }
    public DbSet<Dish> Dishes { get; set; }
    public DbSet<Extras> Extras { get; set; }
    public DbSet<Penalty> Penalties { get; set; }
    public DbSet<Reservation> Reservations { get; set; }

  }
}
