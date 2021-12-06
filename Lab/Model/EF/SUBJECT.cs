namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUBJECTS")]
    public partial class SUBJECT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUBJECT()
        {
            COURSES = new HashSet<COURS>();
            GRADETITLEs = new HashSet<GRADETITLE>();
        }

        public int SubjectId { get; set; }

        [StringLength(50)]
        public string SubjectCode { get; set; }

        [StringLength(50)]
        public string SubjectName { get; set; }

        public int? DepartmentId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COURS> COURSES { get; set; }

        public virtual DEPARTMENT DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRADETITLE> GRADETITLEs { get; set; }
    }
}
