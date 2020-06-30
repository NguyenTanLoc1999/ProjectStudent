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
    public partial class MainGUI : Form
    {
        //public MainGUI()
        //{
        //    InitializeComponent();
        //}
        int userRole;
        private string _displayname;
        private string _displayemail;
        private enum USER_ROLE
        {
            STUDENT = 0,
            LECTURE = 1,
        }
        public MainGUI(bool role, string Displayname, string Displayemail)
        {
            InitializeComponent();
            _displayname = Displayname;
            _displayemail = Displayemail;
            label2.Text = _displayname;
            label3.Text = _displayemail;
            userRole = role ? 1 : 0;

            if (userRole == (int)USER_ROLE.LECTURE)
            {
                MessageBox.Show("YOU LOG IN AS A LECTURE");
            }
            else
            {
                MessageBox.Show("YOU LOG IN AS A STUDENT");
            }
        }




        //==================================================================
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelCenter.Region = region;
            this.Invalidate();
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int lx, ly;
        int sw, sh;

        private void btnmin_Click(object sender, EventArgs e)
        {
            btnmaximum.Visible = true;
            btnmin.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnmaximum_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnmaximum.Visible = false;
            btnmin.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnminimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (userRole == (int)USER_ROLE.LECTURE)
            {
                //MessageBox.Show("YOU LOG IN AS A LECTURE");
                AbrirFormulario<frmStudents>();

            }
            else
            {
                //MessageBox.Show("YOU LOG IN AS A STUDENT");
                frmStudents students = new frmStudents();
                students.btnAdd.Enabled = false;
                students.btnUpdate.Enabled = false;
                students.btnDelete.Enabled = false;
                students.dgvStudent.Enabled = false;
                students.ShowDialog();

            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (userRole == (int)USER_ROLE.LECTURE)
            {
                //MessageBox.Show("YOU LOG IN AS A LECTURE");
                AbrirFormulario<frmLecture>();

            }
            else
            {
                //MessageBox.Show("YOU LOG IN AS A STUDENT");
                frmLecture lecture = new frmLecture();
                lecture.btnAdd.Enabled = false;
                lecture.btnUpdate.Enabled = false;
                lecture.btnDelete.Enabled = false;
                lecture.dgvLecture.Enabled = false;
                lecture.ShowDialog();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (userRole == (int)USER_ROLE.LECTURE)
            {
                //MessageBox.Show("YOU LOG IN AS A LECTURE");
                AbrirFormulario<frmProject>();

            }
            else
            {
                //MessageBox.Show("YOU LOG IN AS A STUDENT");
                frmProject project = new frmProject();
                project.btnUpdate.Enabled = false;
                project.btnSaveProject.Enabled = false;
                project.btnDelete.Enabled = false;
                project.dgvProject.Enabled = false;
                project.ShowDialog();

            }

        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to log out?", "WARNING", MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
            
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form show;
            show = panelShow.Controls.OfType<MiForm>().FirstOrDefault();
            if (show == null)
            {
                show = new MiForm();
                show.TopLevel = false;
                show.FormBorderStyle = FormBorderStyle.None;
                show.Dock = DockStyle.Fill;
                
                panelShow.Controls.Add(show);
                panelShow.Tag = show;
                show.Show();
                show.BringToFront();
            }
            else
            {
                show.BringToFront();
            }
        }
    }
}
