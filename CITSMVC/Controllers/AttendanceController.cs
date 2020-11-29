using CITSMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CITSMVC.Controllers
{
    public class AttendanceController : Controller
    {
        // GET: EmpAttendance
        public ActionResult Index()
        {
            IEnumerable<Attendance> attList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("EmpAttendance").Result;
            attList = response.Content.ReadAsAsync<IEnumerable<Attendance>>().Result;
            return View(attList);
        }
        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            return View(new Attendance());
        }
        [HttpPost]
        public ActionResult AddOrEdit(Attendance att)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("EmpAttendance", att).Result;
            return RedirectToAction("Index");
        }
    }
}