namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROOMS")]
    public partial class ROOM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ROOM()
        {
            COURSE_SCHEDULES = new HashSet<COURSE_SCHEDULES>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomId { get; set; }

        [StringLength(50)]
        public string RoomCode { get; set; }

        public int? CampusId { get; set; }

        public int? CAP2acity { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public virtual CAMPUS CAMPUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COURSE_SCHEDULES> COURSE_SCHEDULES { get; set; }
    }
}
