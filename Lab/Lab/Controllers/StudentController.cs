using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var dao = new StudentCourse_Dao();
            // id=1 Mặc định là sinh viên đầu tiên
            var model = dao.GetCourse(1);
            var name = model.Select(x => x.FirstName).ToList();
            ViewBag.Name = name[0];
            return View(model);
        }
    }
}