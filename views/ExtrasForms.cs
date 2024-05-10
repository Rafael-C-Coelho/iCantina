using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.views
{
    public partial class ExtrasForms : Form
    {
        public ExtrasForms()
        {
            InitializeComponent();
        }

        private void buttonExtras_Click(object sender, EventArgs e)
        {
            string description = textBoxDescriptionExtras.Text;
            double price = Convert.ToDouble(textBoxPriceExtras.Text);

            if(string.IsNullOrWhiteSpace(textBoxDescriptionExtras.Text) && string.IsNullOrWhiteSpace(textBoxPriceExtras.Text))
            {
                MessageBox.Show("Please, insert a description or price of the extra");
                return;
            }
        }
    }
}
