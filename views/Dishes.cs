using iCantina.controllers;
using iCantina.models;
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
    public partial class Dishes : Form

    {
        private bool isMeat;
        private bool isFish;
        private bool isVegetarian;
        private ListDishesController controller;

        public Dishes(bool isMeat, bool isFish, bool isVegetarian)
        {
            InitializeComponent();
            this.isMeat = isMeat;
            this.isFish = isFish;
            this.isVegetarian = isVegetarian;
            controller = new ListDishesController();
        }

        private void Dishes_Load(object sender, EventArgs e)
        {
            lstBoxDishes.SelectedItem = null;
            if (this.isMeat)
            {
                this.Text = "List of meat dishes";
                lblDishes.Text = "Meat dishes";
                lstBoxDishes.DataSource = controller.GetMeatDishes();
            }
            else if (this.isFish)
            {
                this.Text = "List of fish dishes";
                lblDishes.Text = "Fish dishes";
                lstBoxDishes.DataSource = controller.GetFishDishes();
            }
            else
            {
                this.Text = "List of vegetarian dishes";
                lblDishes.Text = "Vegetarian dishes";
                lstBoxDishes.DataSource = controller.GetVegetarianDishes();
            }
        }

        private void txtBoxSearchDishes_TextChanged(object sender, EventArgs e)
        {
            lstBoxDishes.DataSource = null;
            if (this.isMeat)
            {
                lstBoxDishes.DataSource = controller.GetMeatDishes(txtBoxSearchDishes.Text);
            }
            else if (this.isFish)
            {
                lstBoxDishes.DataSource = controller.GetFishDishes(txtBoxSearchDishes.Text);
            }
            else
            {
                lstBoxDishes.DataSource = controller.GetVegetarianDishes(txtBoxSearchDishes.Text);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateDishes createDishes = new CreateDishes(this.isMeat, this.isFish);
            createDishes.Show();
        }


        private void lstBoxDishes_MouseDoubleClick(object sender, MouseEventArgs e) // perguntar ao Gouveia 
        {
            if (lstBoxDishes.SelectedItem != null)
            {
                if (this.isMeat)
                {
                    MeatDish meatDish = (MeatDish)lstBoxDishes.SelectedItem;
                    CreateDishes createDishes = new CreateDishes(this.isMeat, meatDish);
                    createDishes.Show();
                }
                else if (this.isFish)
                {
                    FishDish fishDish = (FishDish)lstBoxDishes.SelectedItem;
                    CreateDishes createDishes = new CreateDishes(this.isFish, fishDish);
                    createDishes.Show();
                }
                else
                {
                    VegetarianDish vegetarianDish = (VegetarianDish)lstBoxDishes.SelectedItem;
                    CreateDishes createDishes = new CreateDishes(this.isMeat, isFish);
                    CreateDishes createDishes1 = new CreateDishes(this.isFish, isMeat);
                    createDishes.Show();
                }
            }
        }

        private void timerDataSourceLstBoxDishes_Tick(object sender, EventArgs e)
        {
            lstBoxDishes.DataSource = null;
            if(this.isMeat)
            {
                lstBoxDishes.DataSource= controller.GetMeatDishes(txtBoxSearchDishes.Text);
            }
            else if (this.isFish)
            {
                lstBoxDishes.DataSource = controller.GetFishDishes(txtBoxSearchDishes.Text);
            }
            else { 
                lstBoxDishes.DataSource = controller.GetVegetarianDishes(txtBoxSearchDishes.Text);
            }
        }
           
    }
}