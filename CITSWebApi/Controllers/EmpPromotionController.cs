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
    public class EmpPromotionController : ApiController
    {
        private CompanyInformationTrackingSystemEntities db = new CompanyInformationTrackingSystemEntities();

        // GET: api/EmpPromotion
        public IQueryable<tb_EmpPromotion> Gettb_EmpPromotion()
        {
            return db.tb_EmpPromotion;
        }

        // GET: api/EmpPromotion/5
        [ResponseType(typeof(tb_EmpPromotion))]
        public IHttpActionResult Gettb_EmpPromotion(int id)
        {
            tb_EmpPromotion tb_EmpPromotion = db.tb_EmpPromotion.Find(id);
            if (tb_EmpPromotion == null)
            {
                return NotFound();
            }

            return Ok(tb_EmpPromotion);
        }

        // PUT: api/EmpPromotion/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttb_EmpPromotion(int id, tb_EmpPromotion tb_EmpPromotion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tb_EmpPromotion.ID)
            {
                return BadRequest();
            }

            db.Entry(tb_EmpPromotion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tb_EmpPromotionExists(id))
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

        // POST: api/EmpPromotion
        [ResponseType(typeof(tb_EmpPromotion))]
        public IHttpActionResult Posttb_EmpPromotion(tb_EmpPromotion tb_EmpPromotion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tb_EmpPromotion.Add(tb_EmpPromotion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tb_EmpPromotion.ID }, tb_EmpPromotion);
        }

        // DELETE: api/EmpPromotion/5
        [ResponseType(typeof(tb_EmpPromotion))]
        public IHttpActionResult Deletetb_EmpPromotion(int id)
        {
            tb_EmpPromotion tb_EmpPromotion = db.tb_EmpPromotion.Find(id);
            if (tb_EmpPromotion == null)
            {
                return NotFound();
            }

            db.tb_EmpPromotion.Remove(tb_EmpPromotion);
            db.SaveChanges();

            return Ok(tb_EmpPromotion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tb_EmpPromotionExists(int id)
        {
            return db.tb_EmpPromotion.Count(e => e.ID == id) > 0;
        }
    }
}