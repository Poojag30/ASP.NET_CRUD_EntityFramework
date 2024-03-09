using EF_C1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_C1.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();
//private object students;

        // GET: Home
        public ActionResult Index()
        {
            var data = db.students.ToList();
            return View(data);
        }
    }
}