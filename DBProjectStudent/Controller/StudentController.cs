using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBProjectStudent.Model;

namespace DBProjectStudent.Controller
{
    public class StudentController
    {
        public static int getIDfromDB()
        {
            using (var _context = new DBProjectStudentEntities())
            {
                var listid = (from t in _context.Students
                              select t.S_ID).ToList();

                //return int.Parse(listid.Max()) + 1;

                string maxID = listid.Max() + 1;
                int i;
                for (i = 1; i < int.Parse(maxID); i++)
                {
                    if (listid.Where(x => x == i.ToString()).Count() <= 0)
                    { return i; }
                }
                return i + 1;
            }
        }
        public static List<Student> getAllStudent()
        {
            using (var _context = new DBProjectStudentEntities())
            {
                var student = (from t in _context.Students.AsEnumerable()
                               select new
                               {
                                   S_ID = t.S_ID,
                                   S_name = t.S_name,
                                   S_fullname = t.S_fullname,
                                   S_major = t.S_major,
                                   S_gender = t.S_gender,
                                   S_birthday = t.S_birthday,
                                   S_phone = t.S_phone,
                                   S_email = t.S_email,

                               }).Select(x => new Student
                               {
                                   S_ID = x.S_ID,
                                   S_name = x.S_name,
                                   S_fullname = x.S_fullname,
                                   S_major = x.S_major,
                                   S_gender = x.S_gender,
                                   S_birthday = x.S_birthday,
                                   S_phone = x.S_phone,
                                   S_email = x.S_email,
                               });
                return student.ToList();
            }
        }
        public static bool addStudent(Student student)
        {
            using (var _context = new DBProjectStudentEntities())
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return true;
            }
        }
        public static List<Student> getAllStudent(string student)
        {
            using (var _context = new DBProjectStudentEntities())
            {
                var students = (from t in _context.Students.AsEnumerable()
                             where t.S_name.Contains(student)
                             select new
                             {
                                 S_ID = t.S_ID,
                                 S_name = t.S_name,
                                 S_fullname = t.S_fullname,
                                 S_major = t.S_major,
                                 S_gender = t.S_gender,
                                 S_birthday = t.S_birthday,
                                 S_phone = t.S_phone,
                                 S_email = t.S_email,

                             }).Select(x => new Student
                             {
                                 S_ID = x.S_ID,
                                 S_name = x.S_name,
                                 S_fullname = x.S_fullname,
                                 S_major = x.S_major,
                                 S_gender = x.S_gender,
                                 S_birthday = x.S_birthday,
                                 S_phone = x.S_phone,
                                 S_email = x.S_email,
                             });
                return students.ToList();
            }
        }
    }
}
