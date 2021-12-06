namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Grade")]
    public partial class Grade
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GradeTitle { get; set; }

        [Column("Grade")]
        public double? Grade1 { get; set; }

        public virtual COURS COURS { get; set; }

        public virtual GRADETITLE GRADETITLE1 { get; set; }

        public virtual STUDENT STUDENT { get; set; }
    }
}
