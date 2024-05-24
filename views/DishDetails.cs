using iCantina.controllers;
using iCantina.helpers;
using iCantina.models;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace iCantina.views
{
  public partial class DishDetails : Form
  {
    private DishDetailsController controller;
    private Dish dish = null;

    public DishDetails()
    {
      InitializeComponent();
    }

    public DishDetails(Dish dish) : this()
    {
      this.dish = dish;
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
      bool success = false;
      success = controller.CreateDish(
        txtBoxName.Text,
        txtBoxDescription.Text,
        rdoBtnMeat.Checked ? helpers.DishTypeEnum.Meat : rdoBtnFish.Checked ? helpers.DishTypeEnum.Fish : helpers.DishTypeEnum.Vegetarian,
        chBoxActive.Checked
      );
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
      controller = new DishDetailsController();
      if (this.dish != null)
      {
        if (this.dish.Type == helpers.DishTypeEnum.Meat)
        {
          rdoBtnMeat.Checked = true;
          rdoBtnFish.Enabled = false;
          rdobtnVegetarian.Enabled = false;
        }
        else if (this.dish.Type == helpers.DishTypeEnum.Fish)
        {
          rdoBtnFish.Checked = true;
          rdoBtnMeat.Enabled = false;
          rdobtnVegetarian.Enabled = false;
        }
        else if (this.dish.Type == helpers.DishTypeEnum.Vegetarian)
        {
          rdobtnVegetarian.Checked = true;
          rdoBtnMeat.Enabled = false;
          rdoBtnFish.Enabled = false;
        }
        txtBoxDescription.Text = this.dish.Description;
        txtBoxName.Text = this.dish.Name;
        chBoxActive.Checked = this.dish.Active;
      }
      checkIfCanDoActions();
    }

    private void checkIfCanDoActions()
    {
      if (this.dish != null)
      {
        if (txtBoxName.Text.Length > 8 && (rdoBtnMeat.Checked || rdoBtnFish.Checked || rdobtnVegetarian.Checked) && Regex.IsMatch(txtBoxName.Text, @"^[a-zA-Z ]+$") && txtBoxDescription.Text.Length> 8)
        {
          btnCreate.Enabled = false;
          btnEdit.Enabled = true;
          btnDelete.Enabled = true;
        }
        else
        {
          btnCreate.Enabled = false;
          btnEdit.Enabled = false;
          btnDelete.Enabled = false;
        }
      }
      else
      {
        if (txtBoxName.Text.Length > 8 && (rdoBtnMeat.Checked || rdoBtnFish.Checked || rdobtnVegetarian.Checked) && Regex.IsMatch(txtBoxName.Text, @"^[a-zA-Z ]+$") && txtBoxDescription.Text.Length > 8)
        {
          btnCreate.Enabled = true;
          btnEdit.Enabled = false;
          btnDelete.Enabled = false;
        }
        else
        {
          btnCreate.Enabled = false;
          btnEdit.Enabled = false;
          btnDelete.Enabled = false;
        }
      }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      if (txtBoxName.Text.Length > 8 && Regex.IsMatch(txtBoxName.Text, @"^[a-zA-Z ]+$"))
      {
        txtBoxName.BackColor = Color.White;
      }
      else
      {
        txtBoxName.BackColor = Color.Red;
      }
      checkIfCanDoActions();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if(this.dish != null)
      {
        if (controller.UpdateDish(this.dish.Id, txtBoxName.Text, txtBoxDescription.Text, rdoBtnMeat.Checked ? DishTypeEnum.Meat : rdoBtnFish.Checked ? DishTypeEnum.Fish : DishTypeEnum.Vegetarian, chBoxActive.Checked))
        {
          MessageBox.Show("Updated successfully!");
          this.Close();
        } else
        {
          MessageBox.Show("Error updating dish!");
        }
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (this.dish != null)
      {
        if (controller.DeleteDish(this.dish.Id))
        {
          MessageBox.Show("Deleted successfully!");
          this.Close();
        }
        else
        {
          MessageBox.Show("Error deleting dish!");
        }
      }
    }

    private void txtBoxName_TextChanged(object sender, EventArgs e)
    {
        if (txtBoxName.Text.Length > 8 && Regex.IsMatch(txtBoxName.Text, @"^[a-zA-Z ]+$"))
      {
            txtBoxName.BackColor = Color.White;
        }
        else
      {
            txtBoxName.BackColor = Color.Red;
        }
    }
  }
}
