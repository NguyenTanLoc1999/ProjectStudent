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
    public partial class frmProgress : Form
    {
        private int _p_id;
        private string _s_id;
        private string _fullname;
        public frmProgress(int P_ID, string S_ID,string Fullname)
        {
            InitializeComponent();
            _p_id = P_ID;
            _s_id = S_ID;
            _fullname = Fullname;
            txtProjectID.Text = _p_id.ToString();
            txtStudentID.Text = _s_id;
            txtStudentName.Text = _fullname;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmProgress_Load(object sender, EventArgs e)
        {

        }


    }
}
