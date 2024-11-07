using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecreationCenter
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void staffPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void staffUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void staffLoginBtn_Click(object sender, EventArgs e)
        {
            if (adminUsername.Text == "" && adminPassword.Text == "")
            {
                MessageBox.Show("Please do not leave empty field");
            }
            else if (adminUsername.Text == "")
            {
                MessageBox.Show("Please enter your user name");
            }
            else if (adminPassword.Text == "")
            {
                MessageBox.Show("Please enter your password");
            }
            else
            {
                if (adminUsername.Text == "admin" && adminPassword.Text == "admin")
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter correct user credentials." +
                        "username = admin and " +
                        "password = admin ");

                }

            }
        }

        private void adminLoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
