using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class ListCourse
    {
        public int Id { get; set; }
        public int C_S { get; set; }
        public DateTime? Date { get; set; }
        public int? Slot { get; set; }
        public string Room { get; set; }
        public string NameInstructor { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string CodeSubject { get; set; }
        public string CodeCourse { get; set; }
        public bool? IsStatus { get; set; } 
        public string Comment { get; set; }
        public int? Total { get; set; }
    }
}
