using DBProjectStudent.Controller;
using DBProjectStudent.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProjectStudent.View
{
    public partial class frmProgress : Form
    {
        private int _p_id;
        private string _s_id;
        private string _fullname;
        public frmProgress(int P_ID, string S_ID,string Fullname)
        {
            InitializeComponent();
            this.cSTT.DataPropertyName = nameof(Progress.STT);
            this.cProjectID.DataPropertyName = nameof(Progress.P_ID);
            this.cStudentID.DataPropertyName = nameof(Progress.S_ID);

            _p_id = P_ID;
            _s_id = S_ID;
            _fullname = Fullname;
            txtProjectID.Text = _p_id.ToString();
            txtStudentID.Text = _s_id;
            txtStudentName.Text = _fullname;

            BindingSource source = new BindingSource();
            source.DataSource = StudentController.listProgressOfStudent(_p_id,_s_id);
            this.dgvProgress.DataSource = source;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmProgress_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            progress.STT = ProgressController.getIDfromDB().ToString();
            progress.P_ID = int.Parse(txtProjectID.Text.Trim());
            progress.S_ID = txtStudentID.Text.Trim();
            progress.ProgressName = txtProjectContent.Text.Trim();
            progress.Note = txtNote.Text.Trim();
            progress.LinkSource = txtLink.Text.Trim();

            if (ProgressController.addProgress(progress) == false)
            {
                MessageBox.Show("Error in adding a new progress!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Add success!!!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            BindingSource source = new BindingSource();
            source.DataSource = StudentController.listProgressOfStudent(_p_id, _s_id);
            this.dgvProgress.DataSource = source;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvProgress.SelectedRows.Count <= 0)
            {
                return;
            }
            string stt = this.dgvProgress.SelectedRows[0].Cells[0].Value.ToString().Trim();
            if (ProgressController.DeleteProgress(stt) == false)
            {
                MessageBox.Show("Cannot delete progress!!!");
            }
            else
            {
                MessageBox.Show("Delete success!!!", "Note", MessageBoxButtons.OK);
                BindingSource source = new BindingSource();
                source.DataSource = StudentController.listProgressOfStudent(_p_id, _s_id);
                this.dgvProgress.DataSource = source;
            }
        }

        private void dgvProgress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvProgress.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtProjectContent.Text = row.Cells[3].Value.ToString();
                txtNote.Text = row.Cells[4].Value.ToString();
                txtLink.Text = row.Cells[5].Value.ToString();
  

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();

            progress.STT = this.dgvProgress.CurrentRow.Cells[0].Value.ToString();
            if (progress.STT.Length <= 0)
                return;

            if (this.dgvProgress.CurrentRow.Cells[1].Value is null)
            {
                this.dgvProgress.CurrentRow.Cells[1].Value = "";

            }
            progress.ProgressName = this.txtProjectContent.Text.Trim();

            if (this.dgvProgress.CurrentRow.Cells[2].Value is null)
            {
                this.dgvProgress.CurrentRow.Cells[2].Value = "";
            }
            progress.Note = this.txtNote.Text.Trim();
            if (this.dgvProgress.CurrentRow.Cells[3].Value is null)
            {
                this.dgvProgress.CurrentRow.Cells[3].Value = "";
            }
            progress.LinkSource = this.txtLink.Text.Trim();
            
            if (ProgressController.UpdateProgress(progress) == false)
            {
                MessageBox.Show("Cannot update!!!");
            }
            else
            {
                MessageBox.Show("Update success", "Note", MessageBoxButtons.OK);
                BindingSource source = new BindingSource();
                source.DataSource = StudentController.listProgressOfStudent(_p_id, _s_id);
                this.dgvProgress.DataSource = source;
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
