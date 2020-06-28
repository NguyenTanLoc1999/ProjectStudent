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
        }

    }
}
