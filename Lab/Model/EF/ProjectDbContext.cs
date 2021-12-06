using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model.EF
{
    public partial class ProjectDbContext : DbContext
    {
        public ProjectDbContext()
            : base("name=ProjectDbContext")
        {
        }

        public virtual DbSet<CAMPUS> CAMPUSES { get; set; }
        public virtual DbSet<COURSE_SCHEDULES> COURSE_SCHEDULES { get; set; }
        public virtual DbSet<COURS> COURSES { get; set; }
        public virtual DbSet<DEPARTMENT> DEPARTMENTS { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<GRADETITLE> GRADETITLEs { get; set; }
        public virtual DbSet<INSTRUCTOR> INSTRUCTORS { get; set; }
        public virtual DbSet<ROLL_CALL_BOOKS> ROLL_CALL_BOOKS { get; set; }
        public virtual DbSet<ROOM> ROOMS { get; set; }
        public virtual DbSet<STUDENT> STUDENTS { get; set; }
        public virtual DbSet<SUBJECT> SUBJECTS { get; set; }
        public virtual DbSet<TERM> TERMS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<COURS>()
                .HasMany(e => e.Grades)
                .WithRequired(e => e.COURS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COURS>()
                .HasMany(e => e.STUDENTS)
                .WithMany(e => e.COURSES)
                .Map(m => m.ToTable("STUDENT_COURSE").MapLeftKey("CourseId").MapRightKey("StudentId"));

            modelBuilder.Entity<GRADETITLE>()
                .HasMany(e => e.Grades)
                .WithRequired(e => e.GRADETITLE1)
                .HasForeignKey(e => e.GradeTitle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<STUDENT>()
                .HasMany(e => e.Grades)
                .WithRequired(e => e.STUDENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUBJECT>()
                .HasMany(e => e.COURSES)
                .WithRequired(e => e.SUBJECT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUBJECT>()
                .HasMany(e => e.GRADETITLEs)
                .WithRequired(e => e.SUBJECT)
                .WillCascadeOnDelete(false);
        }
    }
}
