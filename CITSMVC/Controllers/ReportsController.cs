using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OfficeOpenXml;

namespace CITSMVC.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult Index()
        {
            return View();
        }
        public void EmployeeReport()
        {
            List<StudentViewModel> stdlist = db.students.Select(x => new StudentViewModel
            {
                rollno = x.rollno,
                name = x.name,
                address = x.address
            }).ToList();
            //ExcelPackage.LicenseContext = LicenseContext.Commercial;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage pck = new ExcelPackage();
            ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Report");
            ws.Cells["A1"].Value = "Employee Report";

            ws.Cells["A2"].Value = "Date";
            ws.Cells["B2"].Value = string.Format("{0:dd MMMM yyyy} at {0:H: mm tt}", DateTimeOffset.Now);

            ws.Cells["A5"].Value = "rollno";
            ws.Cells["B5"].Value = "name";
            ws.Cells["C5"].Value = "address";

            int rowStart = 6;

            foreach (var item in stdlist)
            {
                ws.Cells[string.Format("A{0}", rowStart)].Value = item.rollno;
                ws.Cells[string.Format("B{0}", rowStart)].Value = item.name;
                ws.Cells[string.Format("C{0}", rowStart)].Value = item.address;
                rowStart++;
            }
            ws.Cells["A:AZ"].AutoFitColumns();
            Response.Clear();
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            Response.AddHeader("content-disposition", "attachment:filename=" + "ExcelReport.xlsx");
            Response.BinaryWrite(pck.GetAsByteArray());
            Response.End();
        }
        public void AttendanceReport()
        {
            List<StudentViewModel> stdlist = db.students.Select(x => new StudentViewModel
            {
                rollno = x.rollno,
                name = x.name,
                address = x.address
            }).ToList();
            //ExcelPackage.LicenseContext = LicenseContext.Commercial;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage pck = new ExcelPackage();
            ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Report");
            ws.Cells["A1"].Value = "Attendance Report";

            ws.Cells["A2"].Value = "Date";
            ws.Cells["B2"].Value = string.Format("{0:dd MMMM yyyy} at {0:H: mm tt}", DateTimeOffset.Now);

            ws.Cells["A5"].Value = "rollno";
            ws.Cells["B5"].Value = "name";
            ws.Cells["C5"].Value = "address";

            int rowStart = 6;

            foreach (var item in stdlist)
            {
                ws.Cells[string.Format("A{0}", rowStart)].Value = item.rollno;
                ws.Cells[string.Format("B{0}", rowStart)].Value = item.name;
                ws.Cells[string.Format("C{0}", rowStart)].Value = item.address;
                rowStart++;
            }
            ws.Cells["A:AZ"].AutoFitColumns();
            Response.Clear();
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            Response.AddHeader("content-disposition", "attachment:filename=" + "ExcelReport.xlsx");
            Response.BinaryWrite(pck.GetAsByteArray());
            Response.End();
        }
        public void PayrollReport()
        {
            List<StudentViewModel> stdlist = db.students.Select(x => new StudentViewModel
            {
                rollno = x.rollno,
                name = x.name,
                address = x.address
            }).ToList();
            //ExcelPackage.LicenseContext = LicenseContext.Commercial;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage pck = new ExcelPackage();
            ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Report");
            ws.Cells["A1"].Value = "Payroll Report";

            ws.Cells["A2"].Value = "Date";
            ws.Cells["B2"].Value = string.Format("{0:dd MMMM yyyy} at {0:H: mm tt}", DateTimeOffset.Now);

            ws.Cells["A5"].Value = "rollno";
            ws.Cells["B5"].Value = "name";
            ws.Cells["C5"].Value = "address";

            int rowStart = 6;

            foreach (var item in stdlist)
            {
                ws.Cells[string.Format("A{0}", rowStart)].Value = item.rollno;
                ws.Cells[string.Format("B{0}", rowStart)].Value = item.name;
                ws.Cells[string.Format("C{0}", rowStart)].Value = item.address;
                rowStart++;
            }
            ws.Cells["A:AZ"].AutoFitColumns();
            Response.Clear();
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            Response.AddHeader("content-disposition", "attachment:filename=" + "ExcelReport.xlsx");
            Response.BinaryWrite(pck.GetAsByteArray());
            Response.End();
        }
    }
}