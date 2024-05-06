using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    internal class Professor : Client
    {
        public string Email { get; set; }
        
        public Professor()
        {
        }

        public Professor(string name, int nif, float balance, string email) : base(name, nif, balance)
        {
            Email = email;
        }
    }
}
