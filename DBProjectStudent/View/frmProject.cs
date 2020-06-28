using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBProjectStudent.Controller;
using DBProjectStudent.Model;
using ProjectStudent.Controller;

namespace DBProjectStudent.View
{
    public partial class frmProject : Form
    {
        Project getProject;

        private List<string> getIDLecture()
        {
            List<string> lectures = new List<string>();
            using (var _context = new DBProjectStudentEntities())
            {
                var listid = (from t in _context.Lectures
                             select t.L_ID).ToList();
                foreach(var a in listid)
                {
                    lectures.Add(a);                   
                }
            }
            return lectures;
        }
        //Project rowSelected;
        public frmProject()
        {
            
            InitializeComponent();

            
            this.cID.DataPropertyName = nameof(Project.P_ID);
            this.cTitle.DataPropertyName = nameof(Project.P_title);
            this.cDescription.DataPropertyName = nameof(Project.P_description);
            this.cFromtime.DataPropertyName = nameof(Project.P_fromtime);
            this.cTotime.DataPropertyName = nameof(Project.P_totime);
            //this.cStudent.DataPropertyName = nameof(Project.Student.S_fullname);
            
            dgvProject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            BindingSource source = new BindingSource();
            var projects = ProjectController.getAllProject();
            source.DataSource = projects;
            this.dgvProject.DataSource = source;
            this.cmbLecturerID.DataSource = getIDLecture();
        }

        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            Project project = new Project();
            project.P_ID = ProjectController.getIDfromDB();
            project.P_title = this.txtTitle.Text.Trim();
            project.P_description = this.txtDescription.Text.Trim();
            project.P_fromtime = this.dateTimeFrom.Value;
            project.P_totime = this.dateTimeTo.Value;
            project.P_point =this.txtPoint.Text.Trim();
            project.L_ID = this.cmbLecturerID.Text.Trim();
            //Student
            //project.Students = new List<Student>();
            //string displaystudent = "";
            //for (int i = 0; i < listStudents.Items.Count; i++)
            //{
            //    displaystudent = (this.listStudents.Items[i]).ToString() + "\n";
            //    project.Students.Add((this.listStudents.Items[i]) as Student);
            //}
            //project.Lecture = this.listStudents.Text.Trim();
            //project.Lecture = new List<Lecture>();
            //string displaystudent = "";
            //for (int i = 0; i < listStudents.Items.Count; i++)
            //{
            //    displaystudent = (this.listStudents.Items[i]).ToString();
            //    project.Student.Add((this.listStudents.Items[i]) as Student);
            //}
            if (ProjectController.addProject(project) == false)
            {
                MessageBox.Show("Error in adding a new project!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Add success!!!", "Note", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }

            BindingSource source = new BindingSource();
            source.DataSource = ProjectController.getAllProject();
            this.dgvProject.DataSource = source;
        }

        private void dgvProject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // chac chan phai chon 1 hang
            {
                DataGridViewRow row = this.dgvProject.Rows[e.RowIndex];

                txtTitle.Text = row.Cells[1].Value.ToString();
                txtDescription.Text = row.Cells[2].Value.ToString();
                dateTimeFrom.Text = row.Cells[3].Value.ToString();
                dateTimeTo.Text = row.Cells[4].Value.ToString();
                txtPoint.Text = row.Cells[5].Value.ToString();
                cmbLecturerID.Text = row.Cells[6].Value.ToString();

            }
        }

        

        private void listStudentSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvProject.SelectedRows.Count <= 0)
            {
                return;
            }
            int projectid = int.Parse(this.dgvProject.SelectedRows[0].Cells[0].Value.ToString().Trim());
            if (ProjectController.DeleteProject(projectid) == false)
            {
                MessageBox.Show("Cannot delete project!!!");
            }
            else
            {
                MessageBox.Show("Delete success!!!", "Note", MessageBoxButtons.OK);
                BindingSource source = new BindingSource();
                source.DataSource = ProjectController.getAllProject();
                this.dgvProject.DataSource = source;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Project project = new Project();          

            project.P_ID = int.Parse(this.dgvProject.CurrentRow.Cells[0].Value.ToString());
            if (project.P_ID <= 0)
                return;

            if (this.dgvProject.CurrentRow.Cells[1].Value is null)
            {
                this.dgvProject.CurrentRow.Cells[1].Value = "";

            }
            project.P_title = this.txtTitle.Text.Trim();

            if (this.dgvProject.CurrentRow.Cells[2].Value is null)
            {
                this.dgvProject.CurrentRow.Cells[2].Value = "";
            }
            project.P_description = this.txtDescription.Text.Trim();
            if (this.dgvProject.CurrentRow.Cells[3].Value is null)
            {
                this.dgvProject.CurrentRow.Cells[3].Value = "";
            }
            project.P_fromtime = this.dateTimeFrom.Value;
            if (this.dgvProject.CurrentRow.Cells[4].Value is null)
            {
                this.dgvProject.CurrentRow.Cells[4].Value = "";
            }
            project.P_totime = this.dateTimeTo.Value;
            if (this.dgvProject.CurrentRow.Cells[5].Value is null)
            {
                this.dgvProject.CurrentRow.Cells[5].Value = "";
            }
            project.P_point = this.txtPoint.Text.Trim();
            if (this.dgvProject.CurrentRow.Cells[6].Value is null)
            {
                this.dgvProject.CurrentRow.Cells[6].Value = "";
            }
            project.L_ID = this.cmbLecturerID.Text.Trim();
            if (ProjectController.UpdateProject(project) == false)
            {
                MessageBox.Show("Cannot update!!!");
            }
            else
            {
                MessageBox.Show("Update success", "Note", MessageBoxButtons.OK);
                BindingSource source = new BindingSource();
                source.DataSource = ProjectController.getAllProject();
                this.dgvProject.DataSource = source;
            }
        }

        private void dgvProject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // chac chan phai chon 1 hang
            {
                getProject = new Project();
                DataGridViewRow row = this.dgvProject.Rows[e.RowIndex];

                getProject.P_ID = int.Parse(row.Cells[0].Value.ToString());
                getProject.P_title = row.Cells[1].Value.ToString();
                getProject.P_description = row.Cells[2].Value.ToString();
                getProject.L_ID = row.Cells[6].Value.ToString();

                frmProjectDetail frm = new frmProjectDetail(getProject.P_ID, getProject.P_title, getProject.P_description, getProject.L_ID);
                frm.ShowDialog();
            }
            
        }
    }
}
