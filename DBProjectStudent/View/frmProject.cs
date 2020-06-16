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
        Project rowSelected;
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
            project.P_description = this.txtTitle.Text.Trim();
            project.P_fromtime = this.dateTimeFrom.Value;
            project.P_totime = this.dateTimeTo.Value;
            project.P_point = int.Parse(this.txtPoint.Text.Trim());
            project.L_ID = this.cmbLecturerID.Text.Trim();
            //Student
            project.Students = new List<Student>();
            string displaystudent = "";
            for (int i = 0; i < listStudents.Items.Count; i++)
            {
                displaystudent = (this.listStudents.Items[i]).ToString();
                project.Students.Add((this.listStudents.Items[i]) as Student);
            }
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


            BindingSource source = new BindingSource();
            source.DataSource = ProjectController.getAllProject();
            this.dgvProject.DataSource = source;
        }

        private void dgvProject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // chac chan phai chon 1 hang
            {
                rowSelected = new Project();
                //rowSelected.P_ID = int.Parse(dgvProject.SelectedRows[0].Cells["ID"].Value.ToString());
                rowSelected.P_title = dgvProject.SelectedRows[0].Cells[1].Value.ToString();
                rowSelected.P_description = dgvProject.SelectedRows[0].Cells[2].Value.ToString();
                rowSelected.P_fromtime = DateTime.Parse(dgvProject.SelectedRows[0].Cells[3].Value.ToString());
                rowSelected.P_totime = DateTime.Parse(dgvProject.SelectedRows[0].Cells[4].Value.ToString());

                //rowSelected.images = dgvProduct.SelectedRows[0].Cells["Images"].Value.ToString();
                //rowSelected.price = dgvProject.SelectedRows[0].Cells["Price"].Value.ToString();
                //rowSelected.idTypePro = int.Parse(dgvProduct.SelectedRows[0].Cells["TypeProduct"].Value.ToString());



                // hien thi lai tren textbox
                txtTitle.Text = rowSelected.P_title;
                txtDescription.Text = rowSelected.P_description;
                dateTimeFrom.Text = rowSelected.P_fromtime.ToString();
                dateTimeTo.Text = rowSelected.P_totime.ToString();


                //int indexGender = listgender.FindIndex(s => s == rowSelected.gender);
                //cmbGender.SelectedIndex = indexGender;

                //cmbTypePro.SelectedIndex = listTypePro.FindIndex(f => f.id == rowSelected.idTypePro);
            }
        }

        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            List<Student> searchStudent = StudentController.getAllStudent(this.txtStudentSearch.Text.Trim());
            if (searchStudent.Count >= 0)
            {
                this.listStudentSearch.Visible = true;
            }
            else
            {
                this.listStudentSearch.Visible = false;
            }
            //show to the list box
            this.listStudentSearch.Items.Clear();
            for (int i = 0; i < searchStudent.Count; i++)
            {
                this.listStudentSearch.Items.Add(searchStudent[i]);
            } 
            if (txtStudentSearch.Text == "")
                this.listStudentSearch.Items.Clear();
        }

        private void listStudentSearch_DoubleClick(object sender, EventArgs e)
        {
            Student student = (Student)this.listStudentSearch.SelectedItem;
            // check repeat user
            for (int i = 0; i < this.listStudents.Items.Count; i++)
            {
                if (((Student)this.listStudents.Items[i]).S_name == student.S_name)
                {
                    MessageBox.Show("Student name is exist!!");
                    return;
                }
            }
            this.listStudents.Items.Add(student);
            this.listStudentSearch.Visible = false;
        }

        private void listStudents_DoubleClick(object sender, EventArgs e)
        {
            if (this.listStudents.SelectedIndex >= 0)
            {
                this.listStudents.Items.RemoveAt(this.listStudents.SelectedIndex);
            }
        }

        //private void txtLectureSearch_TextChanged(object sender, EventArgs e)
        //{
        //    List<Lecture> searchlecture = LectureController.getAllLecture(this.txtLectureSearch.Text.Trim());
        //    if (searchlecture.Count >= 0)
        //    {
        //        this.listLectureSearch.Visible = true;
        //    }
        //    else
        //    {
        //        this.listLectureSearch.Visible = false;
        //    }
        //    //show to the list box
        //    this.listLectureSearch.Items.Clear();
        //    for (int i = 0; i < searchlecture.Count; i++)
        //    {
        //        this.listLectureSearch.Items.Add(searchlecture[i]);
        //    }
        //    if (txtLectureSearch.Text == "")
        //        this.listLectureSearch.Items.Clear();
        //}

        //private void listLectureSearch_DoubleClick(object sender, EventArgs e)
        //{
        //    //test DemoBranch
        //    Lecture lecture = (Lecture)this.listLectureSearch.SelectedItem;
        //    // check repeat user
        //    for (int i = 0; i < this.listLecture.Items.Count; i++)
        //    {
        //        if (((Lecture)this.listLecture.Items[i]).L_fullname == lecture.L_fullname)
        //        {
        //            MessageBox.Show("Lecture name is exist!!");
        //            return;
        //        }
        //    }
        //    this.listLecture.Items.Add(lecture);
        //    this.listLectureSearch.Visible = false;
        //}

        //private void listLecture_DoubleClick(object sender, EventArgs e)
        //{
        //    if (this.listLecture.SelectedIndex >= 0)
        //    {
        //        this.listLecture.Items.RemoveAt(this.listLecture.SelectedIndex);
        //    }
        //}

        private void listStudentSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvProject.SelectedRows.Count <= 0)
            {
                return;
            }
            int projectname = int.Parse(this.dgvProject.SelectedRows[0].Cells[0].Value.ToString().Trim());
            if (ProjectController.DeleteProject(projectname) == false)
            {
                MessageBox.Show("Cannot delete project!!!");
            }
            else
            {
                BindingSource source = new BindingSource();
                source.DataSource = ProjectController.getAllProject();
                this.dgvProject.DataSource = source;
            }
        }
    }
}
