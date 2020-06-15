using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBProjectStudent.Model;
using DBProjectStudent.Controller;

namespace DBProjectStudent.View
{
    public partial class frmLecture : Form
    {
        List<string> listdepartment = new List<string>()
        {
            "Information Technology",
            "Computer Science",
            "Computer Engineer",
            "Data Science"
        };
        List<string> listgender = new List<string>()
        {
            "Male",
            "Female"
        };
        public frmLecture()
        {
            InitializeComponent();
           
            this.cID.DataPropertyName = nameof(Lecture.L_ID);
            this.cLecturename.DataPropertyName = nameof(Lecture.L_name);
            this.cFullname.DataPropertyName = nameof(Lecture.L_fullname);
            this.cDepartment.DataPropertyName = nameof(Lecture.L_department);
            this.cGender.DataPropertyName = nameof(Lecture.L_gender);
            this.cBirthday.DataPropertyName = nameof(Lecture.L_birthday);
            this.cPhone.DataPropertyName = nameof(Lecture.L_phone);
            this.cEmail.DataPropertyName = nameof(Lecture.L_email);
            this.cmbGender.DataSource = listgender;
            this.cmbDepartment.DataSource = listdepartment;
            BindingSource source = new BindingSource();
            source.DataSource = LectureController.getAllLecture();
            this.dgvLecture.DataSource = source;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Lecture lecture = new Lecture();
            lecture.L_ID = this.txtLectureID.Text.Trim();
            lecture.L_name = this.txtLecturename.Text.Trim();
            lecture.L_fullname = this.txtFullname.Text.Trim();
            lecture.L_department = this.cmbDepartment.Text.Trim();
            lecture.L_gender = this.cmbGender.Text.Trim();
            lecture.L_birthday = DateTime.Parse(this.dateTimeBirthday.Text.Trim());
            lecture.L_email = this.txtEmail.Text.Trim();
            lecture.L_phone = this.txtPhone.Text.Trim();



            if (LectureController.addLecture(lecture) == false)
            {
                MessageBox.Show("Error in adding a new lecture!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            BindingSource source = new BindingSource();
            source.DataSource = LectureController.getAllLecture();
            this.dgvLecture.DataSource = source;
        }
    }
}
