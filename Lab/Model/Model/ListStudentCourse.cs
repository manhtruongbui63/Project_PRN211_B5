using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class ListStudentCourse
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddName { get; set; }
        public string NameSubject { get; set; }
        public string CodeSubject { get; set; }
        public string CodeCourse { get; set; }
    }
}
