using iCantina.controllers;
using iCantina.helpers;
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
        public DishTypeController controller;

        public DishesType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            controller = new DishTypeController();

            DishTypeEnum dishType = new DishTypeEnum();
            if (rdoBtnMeat.Checked)
            {
                dishType = DishTypeEnum.Meat;
            } else if (rdoBtnFish.Checked)
            {
                dishType = DishTypeEnum.Fish;
            } else if (rdoBtnVegetarian.Checked)
            {
                dishType = DishTypeEnum.Vegetarian;
            } else
            {
                MessageBox.Show("Please select the type of dish");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBoxDescription.Text))
            {
                MessageBox.Show("Please, insert a description of the dish");
                return; 
            }

            bool wasCreated = controller.CreateDish(dishType, txtBoxDescription.Text, chBoxActive.Checked);
            if (wasCreated)
            {
                MessageBox.Show("Dish created sucessfully.");
                this.Close();
            } else
            {
                MessageBox.Show("There was an error creating the dish with the specified requirments");
                return ;
            }
        }
    }
}
