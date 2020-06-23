using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBProjectStudent.View;
namespace ProjectStudent
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new frmProgress());
=======
            Application.Run(new HomePage());
>>>>>>> db395bf6411b9e0a8f498effe372d514bbbb8756
        }
    }
}
