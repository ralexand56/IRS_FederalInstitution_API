using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using IRS_FederalInstitutionQL.Models.ECR;

namespace IRS_FederalInstitutionQL.Controllers
{
    public class INS_InstitutionsController : ApiController
    {
        private ECRDB db = new ECRDB();

        // GET: api/INS_Institutions
        public IQueryable<INS_Institutions> GetINS_Institutions()
        {
            return db.INS_Institutions;
        }

        // GET: api/INS_Institutions/5
        [ResponseType(typeof(INS_Institutions))]
        public async Task<IHttpActionResult> GetINS_Institutions(int id)
        {
            INS_Institutions iNS_Institutions = await db.INS_Institutions.FindAsync(id);
            if (iNS_Institutions == null)
            {
                return NotFound();
            }

            return Ok(iNS_Institutions);
        }

        // PUT: api/INS_Institutions/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutINS_Institutions(int id, INS_Institutions iNS_Institutions)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != iNS_Institutions.INS_ID)
            {
                return BadRequest();
            }

            db.Entry(iNS_Institutions).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!INS_InstitutionsExists(id))
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

        // POST: api/INS_Institutions
        [ResponseType(typeof(INS_Institutions))]
        public async Task<IHttpActionResult> PostINS_Institutions(INS_Institutions iNS_Institutions)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.INS_Institutions.Add(iNS_Institutions);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = iNS_Institutions.INS_ID }, iNS_Institutions);
        }

        // DELETE: api/INS_Institutions/5
        [ResponseType(typeof(INS_Institutions))]
        public async Task<IHttpActionResult> DeleteINS_Institutions(int id)
        {
            INS_Institutions iNS_Institutions = await db.INS_Institutions.FindAsync(id);
            if (iNS_Institutions == null)
            {
                return NotFound();
            }

            db.INS_Institutions.Remove(iNS_Institutions);
            await db.SaveChangesAsync();

            return Ok(iNS_Institutions);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool INS_InstitutionsExists(int id)
        {
            return db.INS_Institutions.Count(e => e.INS_ID == id) > 0;
        }
    }
}