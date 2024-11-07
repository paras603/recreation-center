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
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (staffUsername.Text == "" && staffPassword.Text == "")
            {
                MessageBox.Show("Please do not leave empty field");
            }
            else if (staffUsername.Text == "")
            {
                MessageBox.Show("Please enter your user name");
            }
            else if (staffPassword.Text == "")
            {
                MessageBox.Show("Please enter your password");
            }
            else
            {
                if (staffUsername.Text == "staff" && staffPassword.Text == "staff")
                {
                    StaffDashboard staffDashboard = new StaffDashboard();
                    staffDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter correct user credentials." +
                        "username = staff and " +
                        "password = staff ");

                }

            }
        }

        private void staffUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void staffLoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//exits the application
        }
    }
}
