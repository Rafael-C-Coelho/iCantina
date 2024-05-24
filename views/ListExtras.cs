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
  public partial class ListExtras : Form
  {
    ListExtrasController controller = null;

    public ListExtras()
    {
      InitializeComponent();
      controller = new ListExtrasController();
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
      ExtraDetails extraDetails = new ExtraDetails();
      extraDetails.Show();
    }

    private void ListExtras_Load(object sender, EventArgs e)
    {
      lstBoxExtras.DataSource = controller.GetExtras();
    }

    private void timerDataSourceLstBoxExtras_Tick(object sender, EventArgs e)
    {
      lstBoxExtras.DataSource = null;
      lstBoxExtras.DataSource = controller.GetExtras();
    }

    private void lstBoxExtras_DoubleClick(object sender, MouseEventArgs e)
    {
      if (lstBoxExtras.SelectedItem != null)
      {
        Extra extra = (Extra)lstBoxExtras.SelectedItem;
        ExtraDetails clientDetails = new ExtraDetails(extra);
        clientDetails.Show();
        this.Close();
      }
    }
  }
}
