using iCantina.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.controllers
{
    public class LoginController : Controller
    {
        public LoginController()
        {
            Console.WriteLine("Login controller initialized.");
        }

        public Employee Authenticate(string username)
        {
            Employee employee = context.Employees.FirstOrDefault(e => e.Username == username);
            return employee;
        }
    }
}
