namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CAMPUSES")]
    public partial class CAMPUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAMPUS()
        {
            COURSES = new HashSet<COURS>();
            ROOMS = new HashSet<ROOM>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CampusId { get; set; }

        [StringLength(50)]
        public string CampusCode { get; set; }

        [StringLength(100)]
        public string CampusName { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COURS> COURSES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROOM> ROOMS { get; set; }
    }
}
