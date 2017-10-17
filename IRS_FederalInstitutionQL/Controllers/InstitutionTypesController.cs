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
using IRS_FederalInstitutionQL.Models.FederalInstitution;

namespace IRS_FederalInstitutionQL.Controllers
{
    public class InstitutionTypesController : ApiController
    {
        private FederalInstitutionDb db = new FederalInstitutionDb();

        // GET: api/InstitutionTypes
        public IQueryable<InstitutionType> GetInstitutionTypes()
        {
            return db.InstitutionTypes;
        }

        // GET: api/InstitutionTypes/5
        [ResponseType(typeof(InstitutionType))]
        public async Task<IHttpActionResult> GetInstitutionType(int id)
        {
            InstitutionType institutionType = await db.InstitutionTypes.FindAsync(id);
            if (institutionType == null)
            {
                return NotFound();
            }

            return Ok(institutionType);
        }

        // PUT: api/InstitutionTypes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutInstitutionType(int id, InstitutionType institutionType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != institutionType.InstitutionTypeID)
            {
                return BadRequest();
            }

            db.Entry(institutionType).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstitutionTypeExists(id))
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

        // POST: api/InstitutionTypes
        [ResponseType(typeof(InstitutionType))]
        public async Task<IHttpActionResult> PostInstitutionType(InstitutionType institutionType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InstitutionTypes.Add(institutionType);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = institutionType.InstitutionTypeID }, institutionType);
        }

        // DELETE: api/InstitutionTypes/5
        [ResponseType(typeof(InstitutionType))]
        public async Task<IHttpActionResult> DeleteInstitutionType(int id)
        {
            InstitutionType institutionType = await db.InstitutionTypes.FindAsync(id);
            if (institutionType == null)
            {
                return NotFound();
            }

            db.InstitutionTypes.Remove(institutionType);
            await db.SaveChangesAsync();

            return Ok(institutionType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InstitutionTypeExists(int id)
        {
            return db.InstitutionTypes.Count(e => e.InstitutionTypeID == id) > 0;
        }
    }
}