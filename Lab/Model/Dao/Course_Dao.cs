using Model.EF;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class Course_Dao
    {
        ProjectDbContext db = null;
        public Course_Dao()
        {
            db = new ProjectDbContext();
        }

        public List<ListCourse> GetListCourse(int id)
        {
            var model = (from c_s in db.COURSE_SCHEDULES
                         join c in db.COURSES on c_s.CourseId equals c.CourseId
                         join r in db.ROOMS on c_s.RoomId equals r.RoomId
                         join i in db.INSTRUCTORS on c.InstructorId equals i.InstructorId
                         join s in db.SUBJECTS on c.SubjectId equals s.SubjectId
                         join r_c_b in db.ROLL_CALL_BOOKS on c_s.TeachingScheduleId equals r_c_b.TeachingScheduleId where r_c_b.StudentId ==1
                         select new ListCourse
                         {
                             Id = c.CourseId,
                             C_S = c_s.TeachingScheduleId,
                             Date = c_s.TeachingDate,
                             Slot = c_s.Slot,
                             Room = r.RoomCode,
                             NameInstructor = i.InstructorLastName,
                             FirstName = i.InstructorFirstName,
                             MidName = i.InstructorMidName,
                             CodeSubject = s.SubjectCode,
                             CodeCourse = c.CourseCode,
                             IsStatus = r_c_b.IsAbsent,
                             Comment = r_c_b.Comment,
                         }
                         );
            var m = model.Where(x => x.Id == id).OrderBy(x => x.Date).ToList();
            int a = model.Count();
            return m;
        }
    }
}
