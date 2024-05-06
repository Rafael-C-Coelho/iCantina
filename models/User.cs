using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    internal class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int NIF { get; set; }

        public User()
        {
        }

        public User(string name, int nif)
        {
            Name = name;
            NIF = nif;
        }
    }
}
