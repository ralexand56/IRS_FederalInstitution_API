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
    public class FederalEntityTypesController : ApiController
    {
        private FederalInstitutionDb db = new FederalInstitutionDb();

        // GET: api/FederalEntityTypes
        public IQueryable<FederalEntityType> GetFederalEntityTypes()
        {
            return db.FederalEntityTypes;
        }

        // GET: api/FederalEntityTypes/5
        [ResponseType(typeof(FederalEntityType))]
        public async Task<IHttpActionResult> GetFederalEntityType(string id)
        {
            FederalEntityType federalEntityType = await db.FederalEntityTypes.FindAsync(id);
            if (federalEntityType == null)
            {
                return NotFound();
            }

            return Ok(federalEntityType);
        }

        // PUT: api/FederalEntityTypes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutFederalEntityType(string id, FederalEntityType federalEntityType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != federalEntityType.FederalEntityTypeCode)
            {
                return BadRequest();
            }

            db.Entry(federalEntityType).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FederalEntityTypeExists(id))
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

        // POST: api/FederalEntityTypes
        [ResponseType(typeof(FederalEntityType))]
        public async Task<IHttpActionResult> PostFederalEntityType(FederalEntityType federalEntityType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FederalEntityTypes.Add(federalEntityType);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FederalEntityTypeExists(federalEntityType.FederalEntityTypeCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = federalEntityType.FederalEntityTypeCode }, federalEntityType);
        }

        // DELETE: api/FederalEntityTypes/5
        [ResponseType(typeof(FederalEntityType))]
        public async Task<IHttpActionResult> DeleteFederalEntityType(string id)
        {
            FederalEntityType federalEntityType = await db.FederalEntityTypes.FindAsync(id);
            if (federalEntityType == null)
            {
                return NotFound();
            }

            db.FederalEntityTypes.Remove(federalEntityType);
            await db.SaveChangesAsync();

            return Ok(federalEntityType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FederalEntityTypeExists(string id)
        {
            return db.FederalEntityTypes.Count(e => e.FederalEntityTypeCode == id) > 0;
        }
    }
}