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
        private List<string> getNameStudent()
        {
            List<string> student = new List<string>();
            using (var _context = new DBProjectStudentEntities())
            {
                var liststudent = (from t in _context.Students
                              select t.S_fullname).ToList();
                foreach (var a in liststudent)
                {
                    student.Add(a);
                }
            }
            return student;
        }
        public frmProgress()
        {
            InitializeComponent();


            this.cmbStudentName.DataSource = getNameStudent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
