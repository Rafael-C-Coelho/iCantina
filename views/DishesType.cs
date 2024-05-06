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
    public partial class DishesType : Form
    {
        public DishesType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string meat = rdoBtnMeat.Text; 
            string fish = rdoBtnFish.Text;
            string vegetarian = rdoBtnVegetarian.Text;
            string description = txtBoxDescription.Text;

            if (string.IsNullOrWhiteSpace(txtBoxDescription.Text))
            {
                MessageBox.Show("Por favor, insira a descrição do prato");
                return; 
            }


        }
    }
}
