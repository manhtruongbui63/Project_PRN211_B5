namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COURSES")]
    public partial class COURS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COURS()
        {
            COURSE_SCHEDULES = new HashSet<COURSE_SCHEDULES>();
            Grades = new HashSet<Grade>();
            STUDENT_COURSE = new HashSet<STUDENT_COURSE>();
        }

        [Key]
        public int CourseId { get; set; }

        [StringLength(50)]
        public string CourseCode { get; set; }

        [StringLength(300)]
        public string CourseDescription { get; set; }

        public int SubjectId { get; set; }

        public int? InstructorId { get; set; }

        public int? TermId { get; set; }

        public int? CampusID { get; set; }

        public virtual CAMPUS CAMPUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COURSE_SCHEDULES> COURSE_SCHEDULES { get; set; }

        public virtual INSTRUCTOR INSTRUCTOR { get; set; }

        public virtual SUBJECT SUBJECT { get; set; }

        public virtual TERM TERM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grade> Grades { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STUDENT_COURSE> STUDENT_COURSE { get; set; }
    }
}
