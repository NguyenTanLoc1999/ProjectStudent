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
    public partial class frmStudents : Form
    {
        List<string> listmajor = new List<string>()
        {
            "IT",
            "Mechanical Industry",
            "Electronics",
        };
        List<string> listgender = new List<string>()
        {
            "Male",
            "Female"
        };

        public frmStudents()
        {
            InitializeComponent();
            this.cID.DataPropertyName = nameof(Student.S_ID);
            this.cStudentsName.DataPropertyName = nameof(Student.S_name);
            this.cFullname.DataPropertyName = nameof(Student.S_fullname);
            this.cMajors.DataPropertyName = nameof(Student.S_major);
            this.cGender.DataPropertyName = nameof(Student.S_gender);
            this.cBirthday.DataPropertyName = nameof(Student.S_birthday);
            this.cPhone.DataPropertyName = nameof(Student.S_phone);
            this.cEmail.DataPropertyName = nameof(Student.S_email);
            this.cmbGender.DataSource = listgender;
            this.cmbMajor.DataSource = listmajor;
            BindingSource source = new BindingSource();
            source.DataSource = StudentController.getAllStudent();
            this.dgvStudent.DataSource = source;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.S_ID = this.txtStudentID.Text.Trim();
            student.S_name = this.txtStudentname.Text.Trim();
            student.S_fullname = this.txtFullname.Text.Trim();
            student.S_major = this.cmbMajor.Text.Trim();
            student.S_gender = this.cmbGender.Text.Trim();
            student.S_birthday = DateTime.Parse(this.dateTimeBirthday.Text.Trim());
            student.S_email = this.txtEmail.Text.Trim();
            student.S_phone = this.txtPhone.Text.Trim();



            if (StudentController.addStudent(student) == false)
            {
                MessageBox.Show("Error in adding a new student!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            BindingSource source = new BindingSource();
            source.DataSource = StudentController.getAllStudent();
            this.dgvStudent.DataSource = source;
        }
    }
}
