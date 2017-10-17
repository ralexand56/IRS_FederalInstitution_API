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
    public class DepartmentDBsController : ApiController
    {
        private FederalInstitutionDb db = new FederalInstitutionDb();

        // GET: api/DepartmentDBs
        public IQueryable<DepartmentDB> GetDepartmentDBs()
        {
            return db.DepartmentDBs.OrderBy(d => d.Name).Include(a => a.Department);
        }

        // GET: api/DepartmentDBs/5
        [ResponseType(typeof(DepartmentDB))]
        public async Task<IHttpActionResult> GetDepartmentDB(int id)
        {
            DepartmentDB departmentDB = await db.DepartmentDBs.FindAsync(id);
            if (departmentDB == null)
            {
                return NotFound();
            }

            return Ok(departmentDB);
        }

        // PUT: api/DepartmentDBs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDepartmentDB(int id, DepartmentDB departmentDB)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != departmentDB.DeptDBID)
            {
                return BadRequest();
            }

            db.Entry(departmentDB).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentDBExists(id))
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

        // POST: api/DepartmentDBs
        [ResponseType(typeof(DepartmentDB))]
        public async Task<IHttpActionResult> PostDepartmentDB(DepartmentDB departmentDB)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DepartmentDBs.Add(departmentDB);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = departmentDB.DeptDBID }, departmentDB);
        }

        // DELETE: api/DepartmentDBs/5
        [ResponseType(typeof(DepartmentDB))]
        public async Task<IHttpActionResult> DeleteDepartmentDB(int id)
        {
            DepartmentDB departmentDB = await db.DepartmentDBs.FindAsync(id);
            if (departmentDB == null)
            {
                return NotFound();
            }

            db.DepartmentDBs.Remove(departmentDB);
            await db.SaveChangesAsync();

            return Ok(departmentDB);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DepartmentDBExists(int id)
        {
            return db.DepartmentDBs.Count(e => e.DeptDBID == id) > 0;
        }
    }
}