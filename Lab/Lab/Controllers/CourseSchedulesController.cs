using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Controllers
{
    public class CourseSchedulesController : Controller
    {
        // GET: CourseSchedules
        public ActionResult Index()
        {
            var dao = new COURSE_SCHEDULES_Dao();
            var model = dao.Get_Sechedule(33);
            return View(model);
        }
    }
}