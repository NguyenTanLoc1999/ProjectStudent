using DBProjectStudent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjectStudent.Controller
{
    class ProjectManagementController
    {
        public static bool addProjectStudent(ProjectManagement projectM)
        {
            using (var _context = new DBProjectStudentEntities())
            {
                _context.ProjectManagements.Add(projectM);
                _context.SaveChanges();
                return true;
            }
        }
        public static List<ProjectManagement> getAllProjectStudent()
        {
            using (var _context = new DBProjectStudentEntities())
            {
                var project = (from t in _context.ProjectManagements.AsEnumerable()
                               select new
                               {
 
                                   P_ID = t.P_ID,
                                   S_ID = t.S_ID,
                                   Student = t.Student
                               }).Select(x => new ProjectManagement
                               {
  
                                   P_ID = x.P_ID,
                                   S_ID = x.S_ID,
                                   Student = x.Student
                               });
                return project.ToList();
            }
        }
        public static List<Student> getAllStudentbyIDproject(int idproject)
        {
            using (var _context = new DBProjectStudentEntities())
            {
                return _context.ProjectManagements.Where(pm => pm.P_ID == idproject).Select(s => s.Student).ToList(); //dung List<Student>;
            }

        }
        public static bool DeleteProjectStudent(int idproject,string idstudent)
        {
            using (var _context = new DBProjectStudentEntities())
            {
                var student = (from x in _context.ProjectManagements
                               where x.S_ID == idstudent &&x.P_ID  ==idproject
                               select x).SingleOrDefault();

                _context.ProjectManagements.Remove(student);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
