using iCantina.controllers;
using System;
using System.Windows.Forms;

namespace iCantina.views
{
  public partial class CanteenMenu : Form
  {
    private CanteenMenuController controller;

    public CanteenMenu()
    {
      InitializeComponent();
    }

    private void CanteenMenu_Load(object sender, EventArgs e)
    {
      controller = new CanteenMenuController();
      dishLister();
    }

    private void dishLister()
    {
      cmbBoxMeatDish.DataSource = null;
      cmbBoxMeatDish.DataSource = controller.GetDishesByType(helpers.DishTypeEnum.Meat);
      cmbBoxFishDish.DataSource = null;
      cmbBoxFishDish.DataSource = controller.GetDishesByType(helpers.DishTypeEnum.Fish);
      cmbBoxVegetarianDish.DataSource = null;
      cmbBoxVegetarianDish.DataSource = controller.GetDishesByType(helpers.DishTypeEnum.Vegetarian);
      chListBoxExtras.DataSource = null;
      chListBoxExtras.DataSource = controller.GetExtras();
    }

    private void chListBoxExtras_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      if (e.NewValue == CheckState.Checked && chListBoxExtras.CheckedItems.Count >= 3)
      {
        e.NewValue = CheckState.Unchecked;
        MessageBox.Show("You can only select up to 3 extras");
      }
    }
  }
}
