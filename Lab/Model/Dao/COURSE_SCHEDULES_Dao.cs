using Model.EF;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class COURSE_SCHEDULES_Dao
    {
        ProjectDbContext db = null;
        public COURSE_SCHEDULES_Dao()
        {
            db = new ProjectDbContext();
        }

        public List<COURSE_SCHEDULES> Get_Sechedule(int id)
        {
            var model= db.COURSE_SCHEDULES.Where(x => x.CourseId == id).ToList();
            return model;
        }

    }
}
