using iCantina.controllers;
using iCantina.models;
using System;
using System.Windows.Forms;

namespace iCantina.views
{
  public partial class ListDishes : Form

  {
    private ListDishesController controller;

    public ListDishes()
    {
      InitializeComponent();
    }

    private void Dishes_Load(object sender, EventArgs e)
    {
      controller = new ListDishesController();
      lstBoxDishes.SelectedItem = null;
      lstBoxDishes.DataSource = null;
      lstBoxDishes.DataSource = controller.GetDishes();
    }

    private void txtBoxSearchDishes_TextChanged(object sender, EventArgs e)
    {
      lstBoxDishes.DataSource = null;
      lstBoxDishes.DataSource = controller.GetDishes(txtBoxSearchDishes.Text);
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
      DishDetails createDishes = new DishDetails();
      createDishes.Show();
    }


    private void lstBoxDishes_MouseDoubleClick(object sender, MouseEventArgs e) // perguntar ao Gouveia 
    {
      if (lstBoxDishes.SelectedItem != null)
      {
        DishDetails dishDetails = new DishDetails((Dish)lstBoxDishes.SelectedItem);
        dishDetails.Show();
        this.Close();
      }
    }

    private void timerDataSourceLstBoxDishes_Tick(object sender, EventArgs e)
    {
      lstBoxDishes.DataSource = null;
      lstBoxDishes.DataSource = controller.GetDishes(txtBoxSearchDishes.Text);
    }
  }
}
