using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Part52Mvc_.Models;
namespace Part52Mvc_.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            SampleDBContext db = new SampleDBContext();
            List<Employee> employee = db.Employees.ToList();
            return View(employee);
        }
    }
}