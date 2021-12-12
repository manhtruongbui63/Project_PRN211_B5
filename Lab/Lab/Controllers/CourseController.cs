using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Course(int id)
        {
            var dao = new Course_Dao();
            var model = dao.GetListCourse(id);
            int a = model.Count();
            int b = model.Where(x => x.IsStatus == true).Count();
            int c = (int)Math.Ceiling((b * 100) / (float)a);
            ViewBag.Num = c;
            ViewBag.a = a;
            ViewBag.b = b;
            return View(model);
        }
    }
}