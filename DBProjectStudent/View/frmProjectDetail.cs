﻿using DBProjectStudent.Controller;
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
    public partial class frmProjectDetail : Form
    {
        private int id;
        private string _title;
        private string _description;
        private string _lectureid;
        Student rowStudent;
        public frmProjectDetail(int ID, string Title, string Decription,string Lectureid)
        {
            InitializeComponent();

            id = ID;
            _title = Title;
            _description = Decription;
            _lectureid = Lectureid;
            lblProjectID.Text = id.ToString();
            lblProjecttitle.Text = _title;
            lblProjectDescription.Text = _description;
            lblLectureID.Text = _lectureid;

            this.cmbStudentName.DataSource = StudentController.getStudentDetail();
            this.cmbStudentName.DisplayMember = "S_fullname";
            this.cmbStudentName.ValueMember = "S_ID";


            BindingSource source = new BindingSource();
            source.DataSource = ProjectManagementController.getAllStudentbyIDproject(id);
            this.dgvProjectDetail.DataSource = source;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProjectManagement student = new ProjectManagement();
            student.S_ID = this.cmbStudentName.SelectedValue.ToString();
            student.P_ID =id;


            if (ProjectManagementController.addProjectStudent(student) == false)
            {
                MessageBox.Show("Error in adding a new student!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Add success!!!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            BindingSource source = new BindingSource();
            source.DataSource = ProjectManagementController.getAllStudentbyIDproject(id);
            this.dgvProjectDetail.DataSource = source;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvProjectDetail.SelectedRows.Count <= 0)
            {
                return;
            }
            string idstudent =this.dgvProjectDetail.SelectedRows[0].Cells[0].Value.ToString().Trim();
            if (ProjectManagementController.DeleteProjectStudent(idstudent) == false)
            {
                MessageBox.Show("Cannot delete project!!!");
            }
            else
            {
                MessageBox.Show("Delete success!!!", "Note", MessageBoxButtons.OK);
                BindingSource source = new BindingSource();
                source.DataSource = ProjectManagementController.getAllStudentbyIDproject(id);
                this.dgvProjectDetail.DataSource = source;
            }
        }

        private void dgvProjectDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)  // chac chan phai chon 1 hang
            //{
            //    rowStudent = new Student();
            //    DataGridViewRow row = this.dgvProjectDetail.Rows[e.RowIndex];

            //    rowStudent.P_ID = int.Parse(lblProjectID.Text);
            //    rowStudent.S_ID = row.Cells[0].Value.ToString();

            //    frmProgress frm = new frmProgress(rowStudent.P_ID, rowStudent.S_ID);
            //    frm.ShowDialog();
            //}
        }
    }
}
