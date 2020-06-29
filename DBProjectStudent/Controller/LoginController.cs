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
            string temp1 = "0";
            string temp2 = "1";
            using (var _context = new DBProjectStudentEntities())
            {
                var check = from t in _context.UserLogins
                            where (username == t.ID) && (password == t.Pass)
                            select t;
                foreach (var a in check)
                {
                    if (a.roleuser == "0")
                        return temp1;
                    if (a.roleuser == "1")
                        return temp2;
                }
                return "NOTHING";
            }
        }
    }
}
