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
using System.Runtime.InteropServices;

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.S_ID = this.dgvStudent.CurrentRow.Cells[0].Value.ToString();
            if (student.S_ID.Length <= 0)
                return;

            if (this.dgvStudent.CurrentRow.Cells[1].Value is null)
            {
                this.dgvStudent.CurrentRow.Cells[1].Value = "";

            }
            student.S_name = this.txtStudentname.Text.Trim();

            if (this.dgvStudent.CurrentRow.Cells[2].Value is null)
            {
                this.dgvStudent.CurrentRow.Cells[2].Value = "";
            }
            student.S_fullname = this.txtFullname.Text.Trim();
            if (this.dgvStudent.CurrentRow.Cells[3].Value is null)
            {
                this.dgvStudent.CurrentRow.Cells[3].Value = "";
            }
            student.S_major = this.cmbMajor.Text.Trim();
            if (this.dgvStudent.CurrentRow.Cells[4].Value is null)
            {
                this.dgvStudent.CurrentRow.Cells[4].Value = "";
            }
            student.S_gender = this.cmbGender.Text.Trim();
            if (this.dgvStudent.CurrentRow.Cells[5].Value is null)
            {
                this.dgvStudent.CurrentRow.Cells[5].Value = "";
            }
            student.S_birthday = this.dateTimeBirthday.Value;
            if (this.dgvStudent.CurrentRow.Cells[6].Value is null)
            {
                this.dgvStudent.CurrentRow.Cells[6].Value = "";
            }
            student.S_phone = this.txtPhone.Text.Trim();
            if (this.dgvStudent.CurrentRow.Cells[7].Value is null)
            {
                this.dgvStudent.CurrentRow.Cells[7].Value = "";
            }
            student.S_email = this.txtEmail.Text.Trim();
            if (StudentController.UpdateStudent(student) == false)
            {
                MessageBox.Show("Cannot update!!!");
            }
            else
            {
                MessageBox.Show("Update success", "Note", MessageBoxButtons.OK);
                BindingSource source = new BindingSource();
                source.DataSource = StudentController.getAllStudent();
                this.dgvStudent.DataSource = source;
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvStudent.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtStudentID.Text = row.Cells[0].Value.ToString();
                txtStudentname.Text = row.Cells[1].Value.ToString();
                txtFullname.Text = row.Cells[2].Value.ToString();
                cmbMajor.Text = row.Cells[3].Value.ToString();
                dateTimeBirthday.Text = row.Cells[4].Value.ToString();
                txtPhone.Text = row.Cells[5].Value.ToString();
                txtEmail.Text = row.Cells[6].Value.ToString();
                cmbGender.Text = row.Cells[7].Value.ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvStudent.SelectedRows.Count <= 0)
            {
                return;
            }
            string idstudent = this.dgvStudent.SelectedRows[0].Cells[0].Value.ToString().Trim();
            if (StudentController.DeleteStudent(idstudent) == false)
            {
                MessageBox.Show("Cannot delete student!!!");
            }
            else
            {
                MessageBox.Show("Delete success!!!", "Note", MessageBoxButtons.OK);
                BindingSource source = new BindingSource();
                source.DataSource = StudentController.getAllStudent();
                this.dgvStudent.DataSource = source;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
