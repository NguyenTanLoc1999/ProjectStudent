using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBProjectStudent.Model;


namespace ProjectStudent.Controller
{
    public class ProjectController
    {
        public static int getIDfromDB()
        {
            using (var _context = new DBProjectStudentEntities())
            {
                var listid = (from t in _context.Projects
                              select t.P_ID).ToList();

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
        public static List<Project> getAllProject()
        {
            using (var _context = new DBProjectStudentEntities())
            {
                var project = (from t in _context.Projects.AsEnumerable()
                               select new
                               {
                                   P_ID = t.P_ID,
                                   P_title = t.P_title,
                                   P_description = t.P_description,
                                   P_fromtime = t.P_fromtime,
                                   P_totime = t.P_totime,
                                   P_point = t.P_point,
                                   //Students = t.Students,
                                   //L_ID = t.L_ID,
                                   //Lecture = t.Lecture


                            }).Select(x => new Project
                            {
                                P_ID = x.P_ID,
                                P_title = x.P_title,
                                P_description = x.P_description,
                                P_fromtime = x.P_fromtime,
                                P_totime = x.P_totime,
                                P_point = x.P_point,
                                //Students = x.Students,
                                //L_ID = x.L_ID,

                                //Lecture = x.Lecture

                            });
                return project.ToList();
            }
        }
        public static bool addProject(Project project)
        {
            using (var _context = new DBProjectStudentEntities())
            {               
                _context.Projects.Add(project);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool DeleteProject(int idproject)
        {
            using (var _context = new DBProjectStudentEntities())
            {
                var project = (from x in _context.Projects
                            where x.P_ID == idproject
                               select x).Single();

                _context.Projects.Remove(project);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
