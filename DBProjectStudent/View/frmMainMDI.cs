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
        List<Project> listProject;
        List<Lecture> listLecture;
        List<Student> listStudent;
        public frmMainMDI()
        {
            InitializeComponent();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ProjectForm is null || this.ProjectForm.IsDisposed)
            {
                this.ProjectForm = new frmProject();
                this.ProjectForm.MdiParent = this;
                this.ProjectForm.Show();
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
                this.StudentForm.MdiParent = this;
                this.StudentForm.Show();
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
                this.LectureForm.MdiParent = this;
                this.LectureForm.Show();
            }
            else
            {
                this.LectureForm.Select();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
