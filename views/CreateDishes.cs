using iCantina.controllers;
using iCantina.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.views
{
    public partial class CreateDishes : Form
    {
        private CreateDishesController controller;
        private MeatDish meat = null;
        private FishDish fish = null;
        private VegetarianDish vegetarian = null;
        private string title; //armazenar o título 
        private bool isMeat;
        private bool isFish;

        public CreateDishes(bool isMeat, bool isFish)
        {
            InitializeComponent();
            this.isMeat = isMeat;
            this.isFish = isFish;
            if(isMeat)
            {
                this.title = "Meat";
            } 
            else if (isFish)
            {
                this.title = "Fish"; 
            } 
            else
            {
                this.title = "Vegetarian";
            }
            controller = new CreateDishesController();
        }


        public CreateDishes( bool isMeat, MeatDish meatdish) : this(isMeat)
        {
            this.meat = meatdish;
        }

        public CreateDishes(bool isFish, FishDish fishdish) : this(isFish)
        {
            this.fish = fishdish;
        }


        public CreateDishes(bool isMeat)
        {
      
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool success = false;

            if (rdoBtnMeat.Checked)
            {
                success = controller.CreateMeatDish(txtBoxName.Text);
            }
            else if (rdoBtnFish.Checked)
            {
                success = controller.CreateFishDish(txtBoxName.Text);
            }
            else if (rdobtnVegetarian.Checked)
            {
                success = controller.CreateVegetarianDish(txtBoxName.Text);
            }

            if (success)
            {
                MessageBox.Show("Created successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error creating dish!");
            }
        }

        private void CreateDishes_Load(object sender, EventArgs e)
        {
            if (this.title != null)
            {
                this.Text = $"{this.title} page";
                lblDish.Text = this.title;
                if (this.isMeat)
                {
                    rdoBtnMeat.Checked = true;
                    rdoBtnFish.Enabled = false;
                    rdobtnVegetarian.Enabled = false;
                }
                else if (this.isFish)
                {
                    rdoBtnFish.Checked = true;
                    rdoBtnMeat.Enabled = false;
                    rdobtnVegetarian.Enabled = false;
                }
                else
                {
                    rdobtnVegetarian.Checked = true;
                    rdoBtnFish.Enabled = false;
                    rdoBtnMeat.Enabled = false;

                }

            } 
            if (this.meat != null) {
                txtBoxName.Text = this.meat.Name;
                rdoBtnMeat.Checked = true;
                rdoBtnMeat.Enabled = false; 
                rdoBtnFish.Enabled = false ;
                rdobtnVegetarian.Enabled = false; 
                listBoxDescription.DataSource = this.meat.Descriptions;
            }
             else if(this.fish != null) {
                txtBoxName.Text=this.fish.Name;
                rdoBtnFish.Checked = true;
                rdoBtnFish.Enabled = false;
                rdoBtnMeat.Enabled = false;
                rdobtnVegetarian.Enabled = false;
                listBoxDescription.DataSource=this.fish.Descriptions;
            }
            else if (this.vegetarian !=null)
            {
                txtBoxName.Text=this.vegetarian.Name;
                rdobtnVegetarian.Checked = true;
                rdobtnVegetarian.Enabled = false;
                rdoBtnMeat.Enabled = false;
                rdoBtnFish.Enabled=false;
                listBoxDescription.DataSource = this.vegetarian.Descriptions;
            }
            else
            {
                btnCreate.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                listBoxDescription.Enabled = false; 

            }

        }

        private void CheckIfCanCreateDish()
        {
            if (Regex.IsMatch(txtBoxName.Text, @"^[a-zA-Z ]+$"))
            {
                txtBoxName.BackColor = Color.White;
                if(this.meat != null || this.fish != null || this.vegetarian != null)
                    btnEdit.Enabled = true;
                else 
                    CheckIfCanCreateDish();
            }
        }
    }
}
