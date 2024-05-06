using iCantina.controllers;
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
    public partial class Login : Form
    {
        private LoginController controller;
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            controller = new LoginController();
            string username = txtBoxUsername.Text;

            if (controller.Authenticate(username) != null)
            {
                MessageBox.Show("Login successful!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username.");
            }
        }
    }
}
