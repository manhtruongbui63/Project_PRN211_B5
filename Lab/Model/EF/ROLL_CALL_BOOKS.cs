namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ROLL_CALL_BOOKS
    {
        [Key]
        public int RollCallBookId { get; set; }

        public int? TeachingScheduleId { get; set; }

        public int? StudentId { get; set; }

        public bool? IsAbsent { get; set; }

        [StringLength(300)]
        public string Comment { get; set; }

        public virtual COURSE_SCHEDULES COURSE_SCHEDULES { get; set; }

        public virtual STUDENT STUDENT { get; set; }
    }
}
