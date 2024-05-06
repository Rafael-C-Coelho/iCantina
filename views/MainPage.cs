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
    public partial class MainPage : Form
    {
        private Employee employee;

        public MainPage(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.Text = $"Main page (logged in as {this.employee.Name})";
        }
    }
}
