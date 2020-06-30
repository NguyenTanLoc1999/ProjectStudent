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

        private void dgvLecture_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvLecture.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtLectureID.Text = row.Cells[0].Value.ToString();
                txtLecturename.Text = row.Cells[1].Value.ToString();
                txtFullname.Text = row.Cells[2].Value.ToString();
                cmbDepartment.Text = row.Cells[3].Value.ToString();
                cmbGender.Text = row.Cells[4].Value.ToString();
                dateTimeBirthday.Text = row.Cells[5].Value.ToString();
                txtPhone.Text = row.Cells[6].Value.ToString();
                txtEmail.Text = row.Cells[7].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Lecture lecture = new Lecture();

            lecture.L_ID = this.dgvLecture.CurrentRow.Cells[0].Value.ToString();
            if (lecture.L_ID.Length <= 0)
                return;

            if (this.dgvLecture.CurrentRow.Cells[1].Value is null)
            {
                this.dgvLecture.CurrentRow.Cells[1].Value = "";

            }
            lecture.L_name = this.txtLecturename.Text.Trim();

            if (this.dgvLecture.CurrentRow.Cells[2].Value is null)
            {
                this.dgvLecture.CurrentRow.Cells[2].Value = "";
            }
            lecture.L_fullname = this.txtFullname.Text.Trim();
            if (this.dgvLecture.CurrentRow.Cells[3].Value is null)
            {
                this.dgvLecture.CurrentRow.Cells[3].Value = "";
            }
            lecture.L_department = this.cmbDepartment.Text.Trim();
            if (this.dgvLecture.CurrentRow.Cells[4].Value is null)
            {
                this.dgvLecture.CurrentRow.Cells[4].Value = "";
            }
            lecture.L_gender = this.cmbGender.Text.Trim();
            if (this.dgvLecture.CurrentRow.Cells[5].Value is null)
            {
                this.dgvLecture.CurrentRow.Cells[5].Value = "";
            }
            lecture.L_birthday = this.dateTimeBirthday.Value;
            if (this.dgvLecture.CurrentRow.Cells[6].Value is null)
            {
                this.dgvLecture.CurrentRow.Cells[6].Value = "";
            }
            lecture.L_phone = this.txtPhone.Text.Trim();
            if (this.dgvLecture.CurrentRow.Cells[7].Value is null)
            {
                this.dgvLecture.CurrentRow.Cells[7].Value = "";
            }
            lecture.L_email = this.txtEmail.Text.Trim();
            if (LectureController.UpdateLecture(lecture) == false)
            {
                MessageBox.Show("Cannot update!!!");
            }
            else
            {
                MessageBox.Show("Update success", "Note", MessageBoxButtons.OK);
                BindingSource source = new BindingSource();
                source.DataSource = LectureController.getAllLecture();
                this.dgvLecture.DataSource = source;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvLecture.SelectedRows.Count <= 0)
            {
                return;
            }
            string idlecture =this.dgvLecture.SelectedRows[0].Cells[0].Value.ToString().Trim();
            if (LectureController.DeleteLecture(idlecture) == false)
            {
                MessageBox.Show("Cannot delete lecture!!!");
            }
            else
            {
                MessageBox.Show("Delete success!!!", "Note", MessageBoxButtons.OK);
                BindingSource source = new BindingSource();
                source.DataSource = LectureController.getAllLecture();
                this.dgvLecture.DataSource = source;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    }
}
