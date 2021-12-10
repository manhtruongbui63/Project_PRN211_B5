using Model.EF;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class COURSE_SCHEDULES_Dao
    {
        ProjectDbContext db = null;
        public COURSE_SCHEDULES_Dao()
        {
            db = new ProjectDbContext();
        }

        public List<CourseSchedulesByStudentId> GetItem(int id)
        {
            var st = db.STUDENTS.Find(id);
            var model = (from cs in db.COURSE_SCHEDULES
                         join c in db.COURSES on cs.CourseId equals c.CourseId
                         join r in db.ROOMS on cs.RoomId equals r.RoomId
                         join s in db.SUBJECTS on c.SubjectId equals s.SubjectId
                         join i in db.INSTRUCTORS on c.InstructorId equals i.InstructorId
                         select new CourseSchedulesByStudentId()
                         {
                             CourseCode = c.CourseCode,
                             Slot = cs.Slot,
                             TeachingDate = cs.TeachingDate,
                             InstructorLastName = i.InstructorLastName,
                             SubjectCode = s.SubjectCode,
                             RoomId = r.RoomCode,
                         }
                         );
            return model.Where(x => x.StudentId == id).ToList();
        }


        //public List<CourseSchedulesByStudentId> GetItem(int id)
        //{
        //    var st = db.STUDENTS.Find(id);
        //    var model = (from S_Course in db.STUDENT_COURSE
        //                 join S in db.STUDENTS on S_Course.StudentId equals S.StudentId
        //                 join C in db.COURSES on S_Course.CourseId equals C.CourseId
        //                 join C_Schedule in db.COURSE_SCHEDULES on C.CourseId equals C_Schedule.CourseId
        //                 select new CourseSchedulesByStudentId()
        //                 {
        //                     Name = S.FirstName,
        //                     StudentId = S_Course.StudentId,
        //                     CourseCode = C.CourseCode,

        //                 }
        //                 ) ;

        //    return model.Where(x => x.StudentId == id).ToList();
        //}
    }
}
