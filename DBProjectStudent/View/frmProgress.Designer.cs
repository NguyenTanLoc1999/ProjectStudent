namespace DBProjectStudent.View
{
    partial class frmProgress
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
            this.txtProjectContent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.laba = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.dgvProgress = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProjectContent
            // 
            this.txtProjectContent.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectContent.Location = new System.Drawing.Point(787, 59);
            this.txtProjectContent.Name = "txtProjectContent";
            this.txtProjectContent.Size = new System.Drawing.Size(210, 28);
            this.txtProjectContent.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(637, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 55;
            this.label3.Text = "Progress Content";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 54;
            this.label2.Text = "ProjectID";
            // 
            // txtProjectID
            // 
            this.txtProjectID.Enabled = false;
            this.txtProjectID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectID.Location = new System.Drawing.Point(174, 107);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(210, 28);
            this.txtProjectID.TabIndex = 2;
            // 
            // laba
            // 
            this.laba.AutoSize = true;
            this.laba.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laba.Location = new System.Drawing.Point(24, 63);
            this.laba.Name = "laba";
            this.laba.Size = new System.Drawing.Size(86, 21);
            this.laba.TabIndex = 52;
            this.laba.Text = "StudentID";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Enabled = false;
            this.txtStudentID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(174, 59);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(210, 28);
            this.txtStudentID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 57;
            this.label4.Text = "Student Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(637, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 58;
            this.label5.Text = "Link Source";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(637, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 21);
            this.label6.TabIndex = 59;
            this.label6.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(787, 107);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(210, 28);
            this.txtNote.TabIndex = 5;
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Location = new System.Drawing.Point(787, 149);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(210, 28);
            this.txtLink.TabIndex = 6;
            // 
            // dgvProgress
            // 
            this.dgvProgress.AllowUserToAddRows = false;
            this.dgvProgress.AllowUserToDeleteRows = false;
            this.dgvProgress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSTT,
            this.cProjectID,
            this.cStudentID});
            this.dgvProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProgress.Location = new System.Drawing.Point(0, 329);
            this.dgvProgress.Name = "dgvProgress";
            this.dgvProgress.ReadOnly = true;
            this.dgvProgress.RowTemplate.Height = 24;
            this.dgvProgress.Size = new System.Drawing.Size(1058, 306);
            this.dgvProgress.TabIndex = 63;
            this.dgvProgress.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProgress_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(405, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(177, 41);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update Progress";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(630, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 41);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Progress";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(205, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 41);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Progress";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Enabled = false;
            this.txtStudentName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(174, 149);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(210, 28);
            this.txtStudentName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 38);
            this.label1.TabIndex = 77;
            this.label1.Text = "Progress of Student";
            // 
            // cSTT
            // 
            this.cSTT.HeaderText = "STT";
            this.cSTT.Name = "cSTT";
            this.cSTT.ReadOnly = true;
            // 
            // cProjectID
            // 
            this.cProjectID.HeaderText = "Project ID";
            this.cProjectID.Name = "cProjectID";
            this.cProjectID.ReadOnly = true;
            // 
            // cStudentID
            // 
            this.cStudentID.HeaderText = "Student ID";
            this.cStudentID.Name = "cStudentID";
            this.cStudentID.ReadOnly = true;
            // 
            // frmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 635);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvProgress);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProjectContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.laba);
            this.Controls.Add(this.txtStudentID);
            this.Name = "frmProgress";
            this.Text = "frmProgress";
            this.Load += new System.EventHandler(this.frmProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProjectContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.Label laba;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.DataGridView dgvProgress;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStudentID;
    }
}