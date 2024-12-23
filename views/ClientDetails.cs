using iCantina.controllers;
using iCantina.models;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace iCantina.views
{
  public partial class ClientDetails : Form
  {
    private ClientDetailsController controller;
    private Professor professor = null;
    private Student student = null;
    private string title;
    private bool isStudent;

    public ClientDetails(bool isStudent)
    {
      InitializeComponent();
      this.isStudent = isStudent;
      if (isStudent)
      {
        this.title = "Student";
      }
      else
      {
        this.title = "Professor";
      }
      controller = new ClientDetailsController();
    }

    public ClientDetails(bool isStudent, Professor prof) : this(isStudent)
    {
      this.professor = prof;
    }

    public ClientDetails(bool isStudent, Student stud) : this(isStudent)
    {
      this.student = stud;
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
      bool success = false;
      if (rdoBtnProfessor.Checked)
      {
        success = controller.CreateProfessor(txtBoxName.Text, txtBoxNIF.Text, txtBoxVariable.Text, float.TryParse(txtBoxBalance.Text, out float t) ? t : 0);
      }
      else if (rdoBtnStudent.Checked)
      {
        success = controller.CreateStudent(txtBoxName.Text, txtBoxNIF.Text, int.Parse(txtBoxVariable.Text), float.TryParse(txtBoxBalance.Text, out float t) ? t : 0);
      }

      if (success)
      {
        MessageBox.Show("Created successfully!");
        this.Close();
      }
      else
      {
        MessageBox.Show("Error creating client!");
      }
    }

    private void ClientDetails_Load(object sender, EventArgs e)
    {
      if (this.title != null)
      {
        this.Text = $"{this.title} page";
        lblClient.Text = this.title;
        if (this.isStudent)
        {
          rdoBtnStudent.Checked = true;
          rdoBtnProfessor.Enabled = false;
        }
        else
        {
          rdoBtnProfessor.Checked = true;
          rdoBtnStudent.Enabled = false;
        }
      }
      if (this.professor != null)
      {
        txtBoxName.Text = this.professor.Name;
        txtBoxBalance.Text = this.professor.Balance.ToString();
        txtBoxNIF.Text = this.professor.NIF.ToString();
        txtBoxVariable.Text = this.professor.Email;
        lblVariable.Text = "Email";
        rdoBtnProfessor.Checked = true;
        rdoBtnProfessor.Enabled = false;
        rdoBtnStudent.Enabled = false;
        btnCreate.Enabled = false;
        btnEdit.Enabled = true;
        btnDelete.Enabled = true;
        listBoxInvoices.DataSource = this.professor.Invoices; // TODO: Add on click event to show invoice details
      }
      else if (this.student != null)
      {
        txtBoxName.Text = this.student.Name;
        txtBoxBalance.Text = this.student.Balance.ToString();
        txtBoxNIF.Text = this.student.NIF.ToString();
        lblVariable.Text = "Number";
        txtBoxVariable.Text = this.student.StudentNumber.ToString();
        rdoBtnStudent.Checked = true;
        rdoBtnStudent.Enabled = false;
        rdoBtnProfessor.Enabled = false;
        btnCreate.Enabled = false;
        btnEdit.Enabled = true;
        btnDelete.Enabled = true;
        listBoxInvoices.DataSource = this.student.Invoices; // TODO: Add on click event to show invoice details
      }
      else
      {
        btnCreate.Enabled = false;
        btnDelete.Enabled = false;
        btnEdit.Enabled = false;
        listBoxInvoices.Enabled = false;
      }
    }

    private void CheckIfCanCreate()
    {
      if (Regex.IsMatch(txtBoxName.Text, @"^[a-zA-Z ]+$") && Regex.IsMatch(txtBoxNIF.Text, @"^\d{9}$") && Regex.IsMatch(txtBoxBalance.Text, @"^\d+(\.\d{1,2})?$") && Regex.IsMatch(txtBoxVariable.Text, @"^\d+$"))
      {
        btnCreate.Enabled = true;
      }
      else
      {
        btnCreate.Enabled = false;
      }
    }

    private void txtBoxName_TextChanged(object sender, EventArgs e)
    {
      if (Regex.IsMatch(txtBoxName.Text, @"^[a-zA-Z ]+$"))
      {
        txtBoxName.BackColor = Color.White;
        if (this.professor != null || this.student != null)
          btnEdit.Enabled = true;
        else
          CheckIfCanCreate();
      }
      else
      {
        txtBoxName.BackColor = Color.Red;
        btnCreate.Enabled = false;
        btnEdit.Enabled = false;
      }
    }

    private void txtBoxNIF_TextChanged(object sender, EventArgs e)
    {
      if (Regex.IsMatch(txtBoxNIF.Text, @"^\d{9}$"))
      {
        txtBoxNIF.BackColor = Color.White;
        if (this.professor != null || this.student != null)
          btnEdit.Enabled = true;
        else
          CheckIfCanCreate();
      }
      else
      {
        txtBoxNIF.BackColor = Color.Red;
        btnCreate.Enabled = false;
        btnEdit.Enabled = false;
      }
    }

    private void txtBoxBalance_TextChanged(object sender, EventArgs e)
    {
      if (Regex.IsMatch(txtBoxBalance.Text, @"^\d+(\.\d{1,2})?$"))
      {
        txtBoxBalance.BackColor = Color.White;
        if (this.professor != null || this.student != null)
          btnEdit.Enabled = true;
        else
          CheckIfCanCreate();
      }
      else
      {
        txtBoxBalance.BackColor = Color.Red;
        btnCreate.Enabled = false;
        btnEdit.Enabled = false;
      }
    }

    private void txtBoxVariable_TextChanged(object sender, EventArgs e)
    {
      if (Regex.IsMatch(txtBoxVariable.Text, @"^\d+$"))
      {
        txtBoxVariable.BackColor = Color.White;
        if (this.professor != null || this.student != null)
          btnEdit.Enabled = true;
        else
          CheckIfCanCreate();
      }
      else
      {
        txtBoxVariable.BackColor = Color.Red;
        btnEdit.Enabled = false;
        btnCreate.Enabled = false;
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      bool success = false;
      if (rdoBtnProfessor.Checked)
        success = controller.UpdateProfessor(this.professor.Id, txtBoxName.Text, txtBoxNIF.Text, txtBoxVariable.Text, float.TryParse(txtBoxBalance.Text, out float t) ? t : 0);
      else if (rdoBtnStudent.Checked)
        success = controller.UpdateStudent(this.student.Id, txtBoxName.Text, txtBoxNIF.Text, int.Parse(txtBoxVariable.Text), float.Parse(txtBoxBalance.Text));

      if (success)
      {
        MessageBox.Show("Updated successfully!");
        this.Close();
      }
      else
        MessageBox.Show("Error updating client!");
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      bool success = false;
      if (rdoBtnProfessor.Checked)
        success = controller.DeleteProfessor(this.professor.Id);
      else if (rdoBtnStudent.Checked)
        success = controller.DeleteStudent(this.student.Id);

      if (success)
        MessageBox.Show("Deleted successfully!");
      else
        MessageBox.Show("Error deleting client!");

      this.Close();
    }
  }
}
