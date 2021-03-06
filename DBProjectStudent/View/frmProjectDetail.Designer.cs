﻿namespace DBProjectStudent.View
{
    partial class frmProjectDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbStudentName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvProjectDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProjectID = new System.Windows.Forms.Label();
            this.lblProjectDescription = new System.Windows.Forms.Label();
            this.lblProjecttitle = new System.Windows.Forms.Label();
            this.lblLectureID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStudentName
            // 
            this.cmbStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudentName.FormattingEnabled = true;
            this.cmbStudentName.Location = new System.Drawing.Point(294, 197);
            this.cmbStudentName.Name = "cmbStudentName";
            this.cmbStudentName.Size = new System.Drawing.Size(239, 30);
            this.cmbStudentName.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 63;
            this.label4.Text = "Student Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(455, 250);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 41);
            this.btnDelete.TabIndex = 66;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(73, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 41);
            this.btnAdd.TabIndex = 65;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvProjectDetail
            // 
            this.dgvProjectDetail.AllowUserToAddRows = false;
            this.dgvProjectDetail.AllowUserToDeleteRows = false;
            this.dgvProjectDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjectDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cName,
            this.cFullname,
            this.cMajor,
            this.cGender,
            this.cBirthday,
            this.cPhone,
            this.cEmail});
            this.dgvProjectDetail.Location = new System.Drawing.Point(12, 313);
            this.dgvProjectDetail.Name = "dgvProjectDetail";
            this.dgvProjectDetail.ReadOnly = true;
            this.dgvProjectDetail.RowTemplate.Height = 24;
            this.dgvProjectDetail.Size = new System.Drawing.Size(873, 222);
            this.dgvProjectDetail.TabIndex = 67;
            this.dgvProjectDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjectDetail_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 68;
            this.label1.Text = "Project Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 69;
            this.label2.Text = "Project Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 70;
            this.label3.Text = "Project ID";
            // 
            // lblProjectID
            // 
            this.lblProjectID.AutoSize = true;
            this.lblProjectID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectID.Location = new System.Drawing.Point(186, 58);
            this.lblProjectID.Name = "lblProjectID";
            this.lblProjectID.Size = new System.Drawing.Size(87, 21);
            this.lblProjectID.TabIndex = 73;
            this.lblProjectID.Text = "Project ID";
            // 
            // lblProjectDescription
            // 
            this.lblProjectDescription.AutoSize = true;
            this.lblProjectDescription.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectDescription.Location = new System.Drawing.Point(186, 120);
            this.lblProjectDescription.Name = "lblProjectDescription";
            this.lblProjectDescription.Size = new System.Drawing.Size(154, 21);
            this.lblProjectDescription.TabIndex = 72;
            this.lblProjectDescription.Text = "Project Description";
            // 
            // lblProjecttitle
            // 
            this.lblProjecttitle.AutoSize = true;
            this.lblProjecttitle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjecttitle.Location = new System.Drawing.Point(186, 89);
            this.lblProjecttitle.Name = "lblProjecttitle";
            this.lblProjecttitle.Size = new System.Drawing.Size(100, 21);
            this.lblProjecttitle.TabIndex = 71;
            this.lblProjecttitle.Text = "Project Title";
            // 
            // lblLectureID
            // 
            this.lblLectureID.AutoSize = true;
            this.lblLectureID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectureID.Location = new System.Drawing.Point(186, 152);
            this.lblLectureID.Name = "lblLectureID";
            this.lblLectureID.Size = new System.Drawing.Size(90, 21);
            this.lblLectureID.TabIndex = 75;
            this.lblLectureID.Text = "Lecture ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 74;
            this.label6.Text = "Lecture ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 38);
            this.label5.TabIndex = 76;
            this.label5.Text = "Group Student";
            // 
            // cID
            // 
            this.cID.HeaderText = "MSSV";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            // 
            // cName
            // 
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cFullname
            // 
            this.cFullname.HeaderText = "Full Name";
            this.cFullname.Name = "cFullname";
            this.cFullname.ReadOnly = true;
            // 
            // cMajor
            // 
            this.cMajor.HeaderText = "Major";
            this.cMajor.Name = "cMajor";
            this.cMajor.ReadOnly = true;
            // 
            // cGender
            // 
            this.cGender.HeaderText = "Gender";
            this.cGender.Name = "cGender";
            this.cGender.ReadOnly = true;
            // 
            // cBirthday
            // 
            this.cBirthday.HeaderText = "Birthday";
            this.cBirthday.Name = "cBirthday";
            this.cBirthday.ReadOnly = true;
            // 
            // cPhone
            // 
            this.cPhone.HeaderText = "Phone";
            this.cPhone.Name = "cPhone";
            this.cPhone.ReadOnly = true;
            // 
            // cEmail
            // 
            this.cEmail.HeaderText = "Email";
            this.cEmail.Name = "cEmail";
            this.cEmail.ReadOnly = true;
            // 
            // frmProjectDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLectureID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblProjectID);
            this.Controls.Add(this.lblProjectDescription);
            this.Controls.Add(this.lblProjecttitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProjectDetail);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbStudentName);
            this.Controls.Add(this.label4);
            this.Name = "frmProjectDetail";
            this.Text = "Project Detail";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStudentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvProjectDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProjectID;
        private System.Windows.Forms.Label lblProjectDescription;
        private System.Windows.Forms.Label lblProjecttitle;
        private System.Windows.Forms.Label lblLectureID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMajor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
    }
}