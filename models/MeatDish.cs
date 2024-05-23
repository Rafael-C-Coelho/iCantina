using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace iCantina.models
{
    public class MeatDish : CreateDish
    {
        public MeatDish() { 
        }

        public MeatDish(string name) : base(name) { }

        public string Name { get; set; }
    }
}
