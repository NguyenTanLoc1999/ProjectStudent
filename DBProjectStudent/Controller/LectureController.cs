using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBProjectStudent.Model;

namespace DBProjectStudent.Controller
{
    public class LectureController
    {
        public static string getIDfromDB()
        {
            using (var _context = new DBProjectStudentEntities())
            {
                var listid = (from t in _context.Lectures
                              select t.L_ID).ToList();

                //return int.Parse(listid.Max()) + 1;

                return listid.ToString();
            }
        }
        public static List<Lecture> getAllLecture()
        {
            using (var _context = new DBProjectStudentEntities())
            {
                var lecture = (from t in _context.Lectures.AsEnumerable()
                               select new
                               {
                                   L_ID = t.L_ID,
                                   L_name = t.L_name,
                                   L_fullname = t.L_fullname,
                                   L_department = t.L_department,
                                   L_gender = t.L_gender,
                                   L_birthday = t.L_birthday,
                                   L_phone = t.L_phone,
                                   L_email = t.L_email,

                               }).Select(x => new Lecture
                               {
                                   L_ID = x.L_ID,
                                   L_name = x.L_name,
                                   L_fullname = x.L_fullname,
                                   L_department = x.L_department,
                                   L_gender = x.L_gender,
                                   L_birthday = x.L_birthday,
                                   L_phone = x.L_phone,
                                   L_email = x.L_email,
                               });
                return lecture.ToList();
            }
        }
        public static bool addLecture(Lecture lecture)
        {
            using (var _context = new DBProjectStudentEntities())
            {
                _context.Lectures.Add(lecture);
                _context.SaveChanges();
                return true;
            }
        }
        public static List<Lecture> getAllLecture(string lecture)
        {
            using (var _context = new DBProjectStudentEntities())
            {
                var lectures = (from t in _context.Lectures.AsEnumerable()
                                where t.L_name.Contains(lecture)
                                select new
                                {
                                    L_ID = t.L_ID,
                                    L_name = t.L_name,
                                    L_fullname = t.L_fullname,
                                    L_department = t.L_department,
                                    L_gender = t.L_gender,
                                    L_birthday = t.L_birthday,
                                    L_phone = t.L_phone,
                                    L_email = t.L_email,

                                }).Select(x => new Lecture
                                {
                                    L_ID = x.L_ID,
                                    L_name = x.L_name,
                                    L_fullname = x.L_fullname,
                                    L_department = x.L_department,
                                    L_gender = x.L_gender,
                                    L_birthday = x.L_birthday,
                                    L_phone = x.L_phone,
                                    L_email = x.L_email,
                                });
                return lectures.ToList();
            }
        }
    }
}
