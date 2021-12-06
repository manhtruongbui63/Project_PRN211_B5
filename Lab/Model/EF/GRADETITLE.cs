namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GRADETITLE")]
    public partial class GRADETITLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRADETITLE()
        {
            Grades = new HashSet<Grade>();
        }

        public int GradeTitleId { get; set; }

        [Required]
        [StringLength(50)]
        public string GradeTitleName { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public byte Percent { get; set; }

        public int SubjectId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grade> Grades { get; set; }

        public virtual SUBJECT SUBJECT { get; set; }
    }
}
