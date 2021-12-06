namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INSTRUCTORS")]
    public partial class INSTRUCTOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSTRUCTOR()
        {
            COURSES = new HashSet<COURS>();
        }

        public int InstructorId { get; set; }

        [StringLength(50)]
        public string InstructorFirstName { get; set; }

        [StringLength(50)]
        public string InstructorMidName { get; set; }

        [StringLength(50)]
        public string InstructorLastName { get; set; }

        public int? DepartmentId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COURS> COURSES { get; set; }

        public virtual DEPARTMENT DEPARTMENT { get; set; }
    }
}
