using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
  public class Employee : User
  {
    public string Username { get; set; }

    public Employee()
    {
    }

    public Employee(string name, string nif, string username) : base(name, nif)
    {
      Username = username;
    }

    public override string ToString()
    {
      return Name + " - " + NIF + " - " + Username;
    }
  }
}
