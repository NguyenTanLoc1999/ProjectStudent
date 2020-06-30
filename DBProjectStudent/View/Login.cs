using DBProjectStudent.Controller;
using DBProjectStudent.Model;
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
            radioLecture.Checked = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string username = this.txtUsername.Text;
                string pwd = this.txtPassword.Text;

                if (LoginController.checkUser(username, pwd) == true)
                {
                    var lectureLogged = radioLecture.Checked;
                    if(lectureLogged)
                    {
                        var lecture = LectureController.getLectureInfomationAfterLogin(username);                       
                        if (lecture == null)
                        {
                            MessageBox.Show("Login failed ! Please check your information!!!");
                            txtPassword.Text = "";
                            return;
                        }
                        using (var frm = new MainGUI(lectureLogged,lecture.L_fullname,lecture.L_email))
                        {
                            frm.ShowDialog();
                            //this.Hide();
                            txtPassword.Clear();
                            txtUsername.Clear();
                        }
                    }
                    else
                    {
                        var student = StudentController.getStudentInfomationAfterLogin(username);
                        if (student == null)
                        {
                            MessageBox.Show("Login failed ! Please check your information!!!");
                            txtPassword.Text = "";
                            return;
                        }
                        using (var frm = new MainGUI(lectureLogged, student.S_fullname,student.S_email))
                        {
                            frm.ShowDialog();
                            //this.Hide();
                            txtPassword.Clear();
                            txtUsername.Clear();
                        }
                    }
                    
                    
                }
                else
                {
                    MessageBox.Show("Login failed ! Please check your information!!!");
                    txtPassword.Text = "";
                }


            }
            catch
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want stop application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Type Here") { txtUsername.Text = "";txtUsername.ForeColor = Color.LightGray; }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "") { txtUsername.Text = "Type Here"; txtUsername.ForeColor = Color.DimGray; }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") 
            { 
                txtPassword.Text = "Type Here"; 
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Type Here")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
