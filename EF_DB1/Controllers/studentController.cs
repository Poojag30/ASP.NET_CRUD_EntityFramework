using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using entitydb1.context;
namespace entitydb1.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        db_testEntities dbObj = new db_testEntities();
       
        public ActionResult Student()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(tbl_student model)
        {
            tbl_student obj = new tbl_student();
            return View();
        }
        public ActionResult Student()
        {
            return View();
        }
        public ActionResult Student()
        {
            return View();
        }
        public ActionResult Student()
        {
            return View();
        }
        public ActionResult Student()
        {
            return View();
        }

    }
}