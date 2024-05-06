using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    internal class Employee : User
    {
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
