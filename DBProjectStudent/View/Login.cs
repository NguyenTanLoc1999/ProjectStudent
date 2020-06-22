using DBProjectStudent.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProjectStudent.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginController.checkUser(this.txtUsername.Text, this.txtPassword.Text) == true)
                {
                    MessageBox.Show("Login Successfull");
                    if (LoginController.getROLL(this.txtUsername.Text, this.txtPassword.Text) == "Student")
                    {

                        MessageBox.Show("You are student!!!");
                    }
                    else if (LoginController.getROLL(this.txtUsername.Text, this.txtPassword.Text) == "Lecture")
                    {
                        MessageBox.Show("You are lecture!!!");
                    }
                }
                else MessageBox.Show("Login failed ! Please check your information!!!");


            }
            catch
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
