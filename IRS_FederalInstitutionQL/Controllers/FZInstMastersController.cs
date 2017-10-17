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
using IRS_FederalInstitutionQL.Models.CashManagement;

namespace IRS_FederalInstitutionQL.Controllers
{
    public class FZInstMastersController : ApiController
    {
        private CashManagementDB db = new CashManagementDB();

        // GET: api/FZInstMasters
        public List<FZInstMaster> GetFZInstMasters()
        {
            return db.FZInstMasters.ToList();
        }

        // GET: api/FZInstMasters/5
        [ResponseType(typeof(FZInstMaster))]
        public async Task<IHttpActionResult> GetFZInstMaster(string id)
        {
            FZInstMaster fZInstMaster = await db.FZInstMasters.FindAsync(id);
            if (fZInstMaster == null)
            {
                return NotFound();
            }

            return Ok(fZInstMaster);
        }

        // PUT: api/FZInstMasters/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutFZInstMaster(string id, FZInstMaster fZInstMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fZInstMaster.InstID)
            {
                return BadRequest();
            }

            db.Entry(fZInstMaster).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FZInstMasterExists(id))
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

        // POST: api/FZInstMasters
        [ResponseType(typeof(FZInstMaster))]
        public async Task<IHttpActionResult> PostFZInstMaster(FZInstMaster fZInstMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FZInstMasters.Add(fZInstMaster);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FZInstMasterExists(fZInstMaster.InstID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = fZInstMaster.InstID }, fZInstMaster);
        }

        // DELETE: api/FZInstMasters/5
        [ResponseType(typeof(FZInstMaster))]
        public async Task<IHttpActionResult> DeleteFZInstMaster(string id)
        {
            FZInstMaster fZInstMaster = await db.FZInstMasters.FindAsync(id);
            if (fZInstMaster == null)
            {
                return NotFound();
            }

            db.FZInstMasters.Remove(fZInstMaster);
            await db.SaveChangesAsync();

            return Ok(fZInstMaster);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FZInstMasterExists(string id)
        {
            return db.FZInstMasters.Count(e => e.InstID == id) > 0;
        }
    }
}