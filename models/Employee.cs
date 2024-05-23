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
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int nif, string username) : base(name, nif)
        {
            Username = username;
        }
    }
}
