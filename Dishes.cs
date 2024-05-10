using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina
{
    public partial class Dishes : Form
    {
        public Dishes()
        {
            InitializeComponent();
            using (var db = new iCantinaContext())
            {
                List<Dishes> dishes = new List<Dishes>();
               

            }
        }

        private void Dishes_Load(object sender, EventArgs e)
        {

        }
    }
}
