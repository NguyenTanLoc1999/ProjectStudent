using DBProjectStudent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjectStudent.Controller
{
    class LoginController
    {
        public static bool checkUser(string username, string password)
        {

            using (var _context = new DBProjectStudentEntities())
            {
                var check = from t in _context.UserLogins
                            where (username == t.ID) && (password == t.Pass)
                            select t.ID;
                foreach (var a in check)
                {
                    if (a.Length != 0)
                        return true;
                }
                return false;
            }
        }
        public static string getROLL(string username, string password)
        {
            string temp1 = "Student";
            string temp2 = "Lecture";
            using (var _context = new DBProjectStudentEntities())
            {
                var check = from t in _context.UserLogins
                            where (username == t.ID) && (password == t.Pass)
                            select t;
                foreach (var a in check)
                {
                    if (a.roleuser == "Student")
                        return temp1;
                    if (a.roleuser == "Lecture")
                        return temp2;
                }
                return "NOTHING";
            }
        }
    }
}
