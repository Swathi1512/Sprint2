using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CITSWebApi.Models;

namespace CITSWebApi.Controllers
{
    public class EmployeeController : ApiController
    {
        private CompanyInformationTrackingSystemEntities db = new CompanyInformationTrackingSystemEntities();

        // GET: api/Employee
        public IQueryable<tb_Employee> Gettb_Employee()
        {
            return db.tb_Employee;
        }

        // GET: api/Employee/5
        [ResponseType(typeof(tb_Employee))]
        public IHttpActionResult Gettb_Employee(int id)
        {
            tb_Employee tb_Employee = db.tb_Employee.Find(id);
            if (tb_Employee == null)
            {
                return NotFound();
            }

            return Ok(tb_Employee);
        }

        // PUT: api/Employee/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttb_Employee(int id, tb_Employee tb_Employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tb_Employee.EMP_CODE)
            {
                return BadRequest();
            }

            db.Entry(tb_Employee).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tb_EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Employee
        [ResponseType(typeof(tb_Employee))]
        public IHttpActionResult Posttb_Employee(tb_Employee tb_Employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tb_Employee.Add(tb_Employee);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tb_EmployeeExists(tb_Employee.EMP_CODE))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tb_Employee.EMP_CODE }, tb_Employee);
        }

        // DELETE: api/Employee/5
        [ResponseType(typeof(tb_Employee))]
        public IHttpActionResult Deletetb_Employee(int id)
        {
            tb_Employee tb_Employee = db.tb_Employee.Find(id);
            if (tb_Employee == null)
            {
                return NotFound();
            }

            db.tb_Employee.Remove(tb_Employee);
            db.SaveChanges();

            return Ok(tb_Employee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tb_EmployeeExists(int id)
        {
            return db.tb_Employee.Count(e => e.EMP_CODE == id) > 0;
        }
    }
}