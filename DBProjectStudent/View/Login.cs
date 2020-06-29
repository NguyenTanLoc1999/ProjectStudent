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
                        using (var frm = new frmMainMDI(lectureLogged,lecture.L_fullname))
                        {
                            frm.ShowDialog();
                            this.Hide();
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
                        using (var frm = new frmMainMDI(lectureLogged, student.S_fullname))
                        {
                            frm.ShowDialog();
                            this.Hide();
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
    }
}
