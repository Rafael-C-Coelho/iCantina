using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.models
{
    public class Student : Client
    {
        public int StudentNumber { get; set; }

        public Student() { }
        
        public Student(string name, int nif, float balance, int studentNumber) : base(name, nif, balance)
        {
            StudentNumber = studentNumber;
        }
    }
}
