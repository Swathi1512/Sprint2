using CITSMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CITSMVC.Controllers
{
    public class PayrollController : Controller
    {
        // GET: Payroll
        public ActionResult Index()
        {
            IEnumerable<Salary> payrollList;
            HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("EmpSalary").Result;
            payrollList = response.Content.ReadAsAsync<IEnumerable<Salary>>().Result;
            return View(payrollList);
        }
    }
}