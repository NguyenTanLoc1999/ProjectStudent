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
    public partial class frmMainMDI : Form
    {
        frmProject ProjectForm;
        frmLecture LectureForm;
        frmStudents StudentForm;
        int userRole;
        //List<Project> listProject;
        //List<Lecture> listLecture;
        //List<Student> listStudent;
        private string _displayname;
        private enum USER_ROLE
        {
            STUDENT = 0,
            LECTURE = 1,
        }

        public frmMainMDI(bool role,string Displayname)
        {
            InitializeComponent();
            _displayname = Displayname;
            lblName.Text = _displayname;
            userRole = role ? 1 : 0;

            if(userRole == (int)USER_ROLE.LECTURE)
            {
                MessageBox.Show("YOU LOG IN AS A LECTURE");
            }
            else
            {
                MessageBox.Show("YOU LOG IN AS A STUDENT");
            }
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ProjectForm is null || this.ProjectForm.IsDisposed)
            {
                this.ProjectForm = new frmProject();

                if (userRole == (int)USER_ROLE.LECTURE)
                {
                    //MessageBox.Show("YOU LOG IN AS A LECTURE");
                    this.ProjectForm.MdiParent = this;
                    this.ProjectForm.Show();

                }
                else
                {
                    //MessageBox.Show("YOU LOG IN AS A STUDENT");
                    this.ProjectForm.btnDelete.Enabled = false;
                    this.ProjectForm.btnSaveProject.Enabled = false;
                    this.ProjectForm.btnUpdate.Enabled = false;
                    this.ProjectForm.dgvProject.Enabled = false;

                    this.ProjectForm.MdiParent = this;
                    this.ProjectForm.Show();
                }

                
            }
            else
            {
                this.ProjectForm.Select();
            }
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.StudentForm is null || this.StudentForm.IsDisposed)
            {
                this.StudentForm = new frmStudents();
                if (userRole == (int)USER_ROLE.LECTURE)
                {
                    //MessageBox.Show("YOU LOG IN AS A LECTURE");
                    this.StudentForm.MdiParent = this;
                    this.StudentForm.Show();

                }
                else
                {
                    //MessageBox.Show("YOU LOG IN AS A STUDENT");
                    this.StudentForm.btnDelete.Enabled = false;
                    this.StudentForm.btnAdd.Enabled = false;
                    this.StudentForm.btnUpdate.Enabled = false;
                    this.StudentForm.dgvStudent.Enabled = false;
                    this.StudentForm.MdiParent = this;
                    this.StudentForm.Show();
                }
            }
            else
            {
                this.StudentForm.Select();
            }
        }

        private void lectureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.LectureForm is null || this.LectureForm.IsDisposed)
            {
                this.LectureForm = new frmLecture();
                if (userRole == (int)USER_ROLE.LECTURE)
                {
                    //MessageBox.Show("YOU LOG IN AS A LECTURE");
                    this.LectureForm.MdiParent = this;
                    this.LectureForm.Show();

                }
                else
                {
                    //MessageBox.Show("YOU LOG IN AS A STUDENT");
                    this.LectureForm.btnDelete.Enabled = false;
                    this.LectureForm.btnAdd.Enabled = false;
                    this.LectureForm.dgvLecture.Enabled = false;
                    this.LectureForm.btnUpdate.Enabled = false;
                    this.LectureForm.MdiParent = this;
                    this.LectureForm.Show();
                }
            }
            else
            {
                this.LectureForm.Select();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void frmMainMDI_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            if (this.ActiveMdiChild.Tag == null)
            {
                TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                tp.Tag = this.ActiveMdiChild;
                tp.Parent = this.tabControl1;
                this.tabControl1.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            }
        }
    

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab != null && this.tabControl1.SelectedTab.Tag != null)
            {
                (this.tabControl1.SelectedTab.Tag as Form).Select();
            }
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want stop application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
