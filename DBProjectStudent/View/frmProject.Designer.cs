namespace DBProjectStudent.View
{
    partial class frmProject
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.listStudentSearch = new System.Windows.Forms.ListBox();
            this.txtStudentSearch = new System.Windows.Forms.TextBox();
            this.listStudents = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.cmbLecturerID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFromtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 23;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(381, 171);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 42);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete Project";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(193, 170);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 42);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update Project";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProject.Location = new System.Drawing.Point(19, 170);
            this.btnSaveProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(127, 42);
            this.btnSaveProject.TabIndex = 20;
            this.btnSaveProject.Text = "Save Project";
            this.btnSaveProject.UseVisualStyleBackColor = true;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveEvent_Click);
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CustomFormat = "dd/MM/yy HH:mm:ss";
            this.dateTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTo.Location = new System.Drawing.Point(691, 70);
            this.dateTimeTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(249, 27);
            this.dateTimeTo.TabIndex = 19;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CustomFormat = "dd/MM/yy HH:mm:ss";
            this.dateTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFrom.Location = new System.Drawing.Point(691, 20);
            this.dateTimeFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(249, 27);
            this.dateTimeFrom.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(595, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "To Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(595, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "From Time";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(193, 71);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(359, 89);
            this.txtDescription.TabIndex = 15;
            this.txtDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Project\'s Description";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(193, 18);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(359, 27);
            this.txtTitle.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Project\'s Title";
            // 
            // dgvProject
            // 
            this.dgvProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cTitle,
            this.cDescription,
            this.cFromtime,
            this.cTotime});
            this.dgvProject.Location = new System.Drawing.Point(3, 218);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.RowTemplate.Height = 24;
            this.dgvProject.Size = new System.Drawing.Size(1262, 405);
            this.dgvProject.TabIndex = 24;
            this.dgvProject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProject_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(946, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Search Student Name";
            // 
            // listStudentSearch
            // 
            this.listStudentSearch.FormattingEnabled = true;
            this.listStudentSearch.ItemHeight = 20;
            this.listStudentSearch.Location = new System.Drawing.Point(1126, 74);
            this.listStudentSearch.Name = "listStudentSearch";
            this.listStudentSearch.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listStudentSearch.Size = new System.Drawing.Size(120, 84);
            this.listStudentSearch.TabIndex = 27;
            this.listStudentSearch.SelectedIndexChanged += new System.EventHandler(this.listStudentSearch_SelectedIndexChanged);
            this.listStudentSearch.DoubleClick += new System.EventHandler(this.listStudentSearch_DoubleClick);
            // 
            // txtStudentSearch
            // 
            this.txtStudentSearch.Location = new System.Drawing.Point(1125, 22);
            this.txtStudentSearch.Name = "txtStudentSearch";
            this.txtStudentSearch.Size = new System.Drawing.Size(120, 27);
            this.txtStudentSearch.TabIndex = 26;
            this.txtStudentSearch.TextChanged += new System.EventHandler(this.txtStudentSearch_TextChanged);
            // 
            // listStudents
            // 
            this.listStudents.FormattingEnabled = true;
            this.listStudents.ItemHeight = 20;
            this.listStudents.Location = new System.Drawing.Point(999, 74);
            this.listStudents.Name = "listStudents";
            this.listStudents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listStudents.Size = new System.Drawing.Size(120, 84);
            this.listStudents.TabIndex = 25;
            this.listStudents.DoubleClick += new System.EventHandler(this.listStudents_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(595, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Point";
            // 
            // txtPoint
            // 
            this.txtPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoint.Location = new System.Drawing.Point(691, 118);
            this.txtPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(249, 27);
            this.txtPoint.TabIndex = 35;
            // 
            // cmbLecturerID
            // 
            this.cmbLecturerID.FormattingEnabled = true;
            this.cmbLecturerID.Location = new System.Drawing.Point(773, 170);
            this.cmbLecturerID.Name = "cmbLecturerID";
            this.cmbLecturerID.Size = new System.Drawing.Size(167, 28);
            this.cmbLecturerID.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(595, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Search ID Lecture";
            // 
            // cID
            // 
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            // 
            // cTitle
            // 
            this.cTitle.HeaderText = "Title";
            this.cTitle.Name = "cTitle";
            // 
            // cDescription
            // 
            this.cDescription.HeaderText = "Description";
            this.cDescription.Name = "cDescription";
            // 
            // cFromtime
            // 
            this.cFromtime.HeaderText = "From Time";
            this.cFromtime.Name = "cFromtime";
            // 
            // cTotime
            // 
            this.cTotime.HeaderText = "To Time";
            this.cTotime.Name = "cTotime";
            // 
            // frmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 635);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbLecturerID);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listStudentSearch);
            this.Controls.Add(this.txtStudentSearch);
            this.Controls.Add(this.listStudents);
            this.Controls.Add(this.dgvProject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSaveProject);
            this.Controls.Add(this.dateTimeTo);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProject";
            this.Text = "Projects Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSaveProject;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listStudentSearch;
        private System.Windows.Forms.TextBox txtStudentSearch;
        private System.Windows.Forms.ListBox listStudents;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.ComboBox cmbLecturerID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFromtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotime;
    }
}