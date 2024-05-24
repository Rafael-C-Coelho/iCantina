using iCantina.controllers;
using iCantina.models;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace iCantina.views
{
  public partial class ExtraDetails : Form
  {
    Extra extra = null;
    ExtraDetailsController extrasController = null;

    public ExtraDetails()
    {
      InitializeComponent();
    }

    public ExtraDetails(Extra extra) : this()
    {
      this.extra = extra;
    }

    private void checkIfCanActions()
    {
      if (extra != null)
      {
        if (Regex.IsMatch(textBoxDescriptionExtras.Text, @"^[a-zA-Z ]+$") && Regex.IsMatch(textBoxPriceExtras.Text, @"^\d+(\.\d{1,2})?$"))
        {
          btnCreate.Enabled = false;
          btnDelete.Enabled = true;
          btnEdit.Enabled = true;
        }
        else
        {
          btnCreate.Enabled = false;
          btnDelete.Enabled = false;
          btnEdit.Enabled = false;
        }
      } else
      {
        if (Regex.IsMatch(textBoxDescriptionExtras.Text, @"^[a-zA-Z ]+$") && Regex.IsMatch(textBoxPriceExtras.Text, @"^\d+(\.\d{1,2})?$"))
        {
          btnCreate.Enabled = true;
          btnDelete.Enabled = false;
          btnEdit.Enabled = false;
        }
        else
        {
          btnCreate.Enabled = false;
          btnDelete.Enabled = false;
          btnEdit.Enabled = false;
        }
      }
    }

    private void buttonExtras_Click(object sender, EventArgs e)
    {
      string description = textBoxDescriptionExtras.Text;
      double price = Convert.ToDouble(textBoxPriceExtras.Text);
      bool isActive = checkBoxActiveExtras.Checked;
      extrasController.CreateExtras(description, price, isActive);
    }

    private void ExtrasForms_Load(object sender, EventArgs e)
    {
      extrasController = new ExtraDetailsController();
      if (extra != null)
      {
        textBoxDescriptionExtras.Text = extra.Description;
        textBoxPriceExtras.Text = extra.Price.ToString();
        checkBoxActiveExtras.Checked = extra.Active;
      }
      checkIfCanActions();
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
      bool success = extrasController.CreateExtras(textBoxDescriptionExtras.Text, Convert.ToDouble(textBoxPriceExtras.Text), checkBoxActiveExtras.Checked);
      if (success)
      {
        MessageBox.Show("Extra created successfully");
        this.Close();
      }
      else
      {
        MessageBox.Show("Error creating extra");
      }
    }

    private void textBoxDescriptionExtras_TextChanged(object sender, EventArgs e)
    {
      if (Regex.IsMatch(textBoxDescriptionExtras.Text, @"^[a-zA-Z ]+$"))
      {
        textBoxDescriptionExtras.BackColor = Color.White;
      }
      else
      {
        textBoxDescriptionExtras.BackColor = Color.Red;
      }
      checkIfCanActions();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      bool success = extrasController.UpdateExtras(extra.Id, textBoxDescriptionExtras.Text, Convert.ToDouble(textBoxPriceExtras.Text), checkBoxActiveExtras.Checked);
      if (success)
      {
        MessageBox.Show("Extra updated successfully");
        this.Close();
      }
      else
      {
        MessageBox.Show("Error updating extra");
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      bool success = extrasController.DeleteExtras(extra.Id);
      if (success)
      {
        MessageBox.Show("Extra deleted successfully");
        this.Close();
      }
      else
      {
        MessageBox.Show("Error deleting extra");
      }
    }

    private void textBoxPriceExtras_TextChanged(object sender, EventArgs e)
    {
      if (Regex.IsMatch(textBoxPriceExtras.Text, @"^\d+(\.\d{1,2})?$"))
      {
        textBoxPriceExtras.BackColor = Color.White;
      }
      else
      {
        textBoxPriceExtras.BackColor = Color.Red;
      }
      checkIfCanActions();
    }
  }
}
