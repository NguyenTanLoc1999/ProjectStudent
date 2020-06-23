using DBProjectStudent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjectStudent.Controller
{
    class ProgressController
    {
        public static int getIDfromDB()
        {
            using (var _context = new DBProjectStudentEntities())
            {
                var listid = (from t in _context.Progresses
                              select t.ID).ToList();

                //return int.Parse(listid.Max()) + 1;

                int maxID = listid.Max() + 1;
                int i;
                for (i = 1; i < maxID; i++)
                {
                    if (listid.Where(x => x == i).Count() <= 0)
                    { return i; }
                }
                return i + 1;
            }
        }
        public static List<Progress> getAllProgress()
        {
            using (var _context = new DBProjectStudentEntities())
            {
                var progresses = (from t in _context.Progresses.AsEnumerable()
                               select new
                               {
                                   ID = t.ID,
                                   P_ID = t.P_ID,
                                   ProgressName = t.ProgressName,
                                   StudentName = t.StudentName,
                                   LinkSource = t.LinkSource,
                                   Note = t.Note,


                               }).Select(x => new Progress
                               {
                                   ID = x.ID,
                                   P_ID = x.P_ID,
                                   ProgressName = x.ProgressName,
                                   StudentName = x.StudentName,
                                   LinkSource = x.LinkSource,
                                   Note = x.Note
                               });
                return progresses.ToList();
            }
        }
        public static bool addProgress(Progress progress)
        {
            using (var _context = new DBProjectStudentEntities())
            {
                _context.Progresses.Add(progress);
                _context.SaveChanges();
                return true;
            }
        }
        public static List<Progress> getAllProgress(string progress)
        {
            using (var _context = new DBProjectStudentEntities())
            {
                var pro = (from t in _context.Progresses.AsEnumerable()
                                where (t.P_ID).ToString().Contains(progress)
                                select new
                                {
                                    ID = t.ID,
                                    P_ID = t.P_ID,
                                    ProgressName = t.ProgressName,
                                    StudentName = t.StudentName,
                                    LinkSource = t.LinkSource,
                                    Note = t.Note,

                                }).Select(x => new Progress
                                {
                                    ID = x.ID,
                                    P_ID = x.P_ID,
                                    ProgressName = x.ProgressName,
                                    StudentName = x.StudentName,
                                    LinkSource = x.LinkSource,
                                    Note = x.Note
                                });
                return pro.ToList();
            }
        }
    }
}
