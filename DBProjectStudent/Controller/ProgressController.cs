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
                              select t.STT).ToList();

                //return int.Parse(listid.Max()) + 1;

                int maxID = int.Parse(listid.Max() + 1);
                int i;
                for (i = 1; i < maxID; i++)
                {
                    if (listid.Where(x => x == i.ToString()).Count() <= 0)
                    { return i; }
                }
                return i + 1;
            }
        }
        public static List<Progress> getAllProgress()
        {
            using (var _context = new DBProjectStudentEntities())
            {
                var progress = (from t in _context.Progresses.AsEnumerable()
                               select new
                               {
                                   STT = t.STT,
                                   P_ID = t.P_ID,
                                   S_ID = t.S_ID,
                                   ProgressName = t.ProgressName,
                                   LinkSource = t.LinkSource,
                                   Note = t.Note,

                               }).Select(x => new Progress
                               {
                                   STT = x.STT,
                                   P_ID = x.P_ID,
                                   S_ID = x.S_ID,
                                   ProgressName = x.ProgressName,
                                   LinkSource = x.LinkSource,
                                   Note = x.Note,

                               });
                return progress.ToList();
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
        public static bool DeleteProgress(string stt)
        {
            using (var _context = new DBProjectStudentEntities())
            {
                var progress = (from x in _context.Progresses
                               where x.STT == stt
                               select x).Single();

                _context.Progresses.Remove(progress);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool UpdateProgress(Progress progressadd)
        {
            using (var _context = new DBProjectStudentEntities())
            {
                var progress = (from u in _context.Progresses
                               where u.STT == progressadd.STT
                               select u).Single();
                progress.ProgressName = progressadd.ProgressName;
                progress.LinkSource = progressadd.LinkSource;
                progress.Note = progressadd.Note;
                //_context.Projects.Add(project);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
