using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMvcApp.Models;
using System.Web.Security;

namespace FirstMvcApp.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string FirstName)
        {
            Attendance.AddAttendant(FirstName);
            TempData["FirstName"] = FirstName;
            return RedirectToAction("Index");
        }
    }
}