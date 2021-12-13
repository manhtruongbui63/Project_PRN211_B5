using Model.EF;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class StudentCourse_Dao
    {
        ProjectDbContext db = null;
        public StudentCourse_Dao()
        {
            db = new ProjectDbContext();
        }
        public List<ListStudentCourse> GetCourse(int id)
        {
            var model = (from s_c in db.STUDENT_COURSE 
                         join c in db.COURSES on s_c.CourseId equals c.CourseId
                         join s in db.STUDENTS on s_c.StudentId equals s.StudentId
                         join sub in db.SUBJECTS on c.SubjectId equals sub.SubjectId
                         select new ListStudentCourse
                         {
                             ID = c.CourseId,
                             StudentID = s.StudentId,
                             CodeCourse = c.CourseCode,
                             NameSubject = sub.SubjectName,
                             CodeSubject = sub.SubjectCode,
                             LastName = s.LastName,
                             FirstName = s.FirstName,
                             MiddName = s.MidName
                         }
                         );
            return model.Where(x => x.StudentID == id).ToList();
        }
    }
}
