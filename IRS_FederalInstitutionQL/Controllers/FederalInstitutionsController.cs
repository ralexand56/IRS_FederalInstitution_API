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
using IRS_FederalInstitutionQL.Models;
using IRS_FederalInstitutionQL.Models.Deposit;

namespace IRS_FederalInstitutionQL.Controllers
{
    public class FederalInstitutionsController : ApiController
    {
        private FederalInstitutionDb db = new FederalInstitutionDb();
        private DepositDB depositDB = new DepositDB();
        //private List<DepartmentDB> DepartmentDBs;

        private List<FederalInstitutionCount> fedInstitutionCounts = new List<FederalInstitutionCount>();

        FederalInstitutionsController()
        {
            //DepartmentDBs = db.DepartmentDBs.Where(x => x.IsActive).ToList();

            //var depositBanks = depositDB.BANKs
            //    .Where(x => x.BA_ACTIVE == "A" && x.BA_KEY_ID != null).ToList();

            //depositBanks
            //    .Select(x => Convert.ToInt32(x.BA_KEY_ID)).Distinct().ToList()
            //    .ForEach(z =>
            //    {
            //        fedInstitutionCounts.Add(new FederalInstitutionCount()
            //        {
            //            RSSDID = z,
            //            Count = depositBanks.Where(a => a.BA_KEY_ID == z.ToString()).Count(),
            //            DepartmentDB = DepartmentDBs.FirstOrDefault(b => b.DeptDBID == 1)
            //        });
            //    });
        }

        [HttpPost]
        public IQueryable<FederalInstitution> GetFederalInstitutions(FederalInstitutionFilter fedFilter)
        {
            return GetFilteredFederalInstitutions(fedFilter);
        }

        // GET: api/FederalInstitutions/5
        [ResponseType(typeof(FederalInstitution))]
        public async Task<IHttpActionResult> GetFederalInstitution(int id)
        {
            FederalInstitution federalInstitution = await db.FederalInstitutions.FindAsync(id);
            if (federalInstitution == null)
            {
                return NotFound();
            }

            return Ok(federalInstitution);
        }

        private IQueryable<FederalInstitution> GetFilteredFederalInstitutions(FederalInstitutionFilter filter)
        {
            var filteredFedInsts = db.FederalInstitutions.Include(x => x.FederalEntityType).Where(f => f.IsActive);

            if (filter.RSSDID.HasValue)
            {
                return filteredFedInsts.Where(x => x.RSSDID == filter.RSSDID.Value);
            } 

            filteredFedInsts = filter.isStartsWith
                ? filteredFedInsts.Where(x => x.Name.StartsWith(filter.searchTxt) || x.FullName.StartsWith(filter.searchTxt))
                : filteredFedInsts.Where(x => x.Name.Contains(filter.searchTxt) || x.FullName.Contains(filter.searchTxt));

            var filterStates = filter.selectedStates.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

            filteredFedInsts = filterStates.Count > 0
                ? filteredFedInsts.Where(x => filterStates.Contains(x.StateCode))
                : filteredFedInsts;

            return filteredFedInsts;
        }

        // PUT: api/FederalInstitutions/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutFederalInstitution(int id, FederalInstitution federalInstitution)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != federalInstitution.RSSDID)
            {
                return BadRequest();
            }

            db.Entry(federalInstitution).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FederalInstitutionExists(id))
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

        //// POST: api/FederalInstitutions
        //[ResponseType(typeof(FederalInstitution))]
        //public async Task<IHttpActionResult> PostFederalInstitution(FederalInstitution federalInstitution)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.FederalInstitutions.Add(federalInstitution);

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (FederalInstitutionExists(federalInstitution.RSSDID))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = federalInstitution.RSSDID }, federalInstitution);
        //}

        // DELETE: api/FederalInstitutions/5
        [ResponseType(typeof(FederalInstitution))]
        public async Task<IHttpActionResult> DeleteFederalInstitution(int id)
        {
            FederalInstitution federalInstitution = await db.FederalInstitutions.FindAsync(id);
            if (federalInstitution == null)
            {
                return NotFound();
            }

            db.FederalInstitutions.Remove(federalInstitution);
            await db.SaveChangesAsync();

            return Ok(federalInstitution);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FederalInstitutionExists(int id)
        {
            return db.FederalInstitutions.Count(e => e.RSSDID == id) > 0;
        }
    }
}