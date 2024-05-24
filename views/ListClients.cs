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
  public partial class ListClients : Form
  {
    private bool isStudent;
    private ListClientsController controller;

    public ListClients(bool isStudent)
    {
      InitializeComponent();
      this.isStudent = isStudent;
      controller = new ListClientsController();
    }

    private void ListClients_Load(object sender, EventArgs e)
    {
      lstBoxClients.SelectedItem = null;
      if (this.isStudent)
      {
        this.Text = "List of students";
        lblClient.Text = "Students";
        lstBoxClients.DataSource = controller.GetStudents();
      }
      else
      {
        this.Text = "List of professors";
        lblClient.Text = "Professors";
        lstBoxClients.DataSource = controller.GetProfessors();
      }
    }

    private void txtBoxSearch_TextChanged(object sender, EventArgs e)
    {
      lstBoxClients.DataSource = null;
      if (this.isStudent)
      {
        lstBoxClients.DataSource = controller.GetStudents(txtBoxSearch.Text);
      }
      else
      {
        lstBoxClients.DataSource = controller.GetProfessors(txtBoxSearch.Text);
      }
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
      ClientDetails clientDetails = new ClientDetails(this.isStudent);
      clientDetails.Show();
    }

    private void lstBoxClients_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (lstBoxClients.SelectedItem != null)
      {
        if (this.isStudent)
        {
          Student student = (Student)lstBoxClients.SelectedItem;
          ClientDetails clientDetails = new ClientDetails(this.isStudent, student);
          clientDetails.Show();
          this.Close();
        }
        else
        {
          Professor professor = (Professor)lstBoxClients.SelectedItem;
          ClientDetails clientDetails = new ClientDetails(this.isStudent, professor);
          clientDetails.Show();
          this.Close();
        }
      }
    }

    private void timerDataSourceListBox_Tick(object sender, EventArgs e)
    {
      lstBoxClients.DataSource = null;
      if (this.isStudent)
      {
        lstBoxClients.DataSource = controller.GetStudents(txtBoxSearch.Text);
      }
      else
      {
        lstBoxClients.DataSource = controller.GetProfessors(txtBoxSearch.Text);
      }
    }
  }
}
