using iCantina.models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace iCantina.views
{
  public partial class ReservationForm : Form
  {
    public ReservationForm()
    {
      InitializeComponent();
    }

    private void checkedListBoxExtrasReservation_SelectedIndexChanged(object sender, EventArgs e)
    {
      ICollection<Extra> extras = new List<Extra>();
    }

    private void buttonReservation_Click(object sender, EventArgs e)
    {

    }

    private void comboBoxClientCreate_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
