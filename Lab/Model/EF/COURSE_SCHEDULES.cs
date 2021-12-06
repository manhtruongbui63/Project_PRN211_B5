namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COURSE_SCHEDULES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COURSE_SCHEDULES()
        {
            ROLL_CALL_BOOKS = new HashSet<ROLL_CALL_BOOKS>();
        }

        [Key]
        public int TeachingScheduleId { get; set; }

        public int? CourseId { get; set; }

        public DateTime? TeachingDate { get; set; }

        public int? Slot { get; set; }

        public int? RoomId { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        public virtual COURS COURS { get; set; }

        public virtual ROOM ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROLL_CALL_BOOKS> ROLL_CALL_BOOKS { get; set; }
    }
}
