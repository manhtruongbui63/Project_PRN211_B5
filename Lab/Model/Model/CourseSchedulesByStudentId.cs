using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class CourseSchedulesByStudentId
    {
        public int StudentId { get; set; }
        public int TeachingSchedule { get; set; }
        public int CourseId { get; set; }
        public DateTime? TeachingDate { get; set; }
        public int? Slot { get; set; }
        public string RoomId { get; set; }
        public string CourseCode { get; set; }
        public int SubjectId { get; set; }
        public int InstructorId { get; set; }
        public string SubjectCode { get; set; }
        public string InstructorLastName { get; set; }


        //
        public string Name { get; set; }

    }
}
