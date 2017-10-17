using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using IRS_FederalInstitutionQL.Models;
using GraphQL.Net;
using IRS_FederalInstitutionQL.Models.FederalInstitution;
using Newtonsoft.Json;

namespace IRS_FederalInstitutionQL.Controllers
{
    public class HomeController : ApiController
    {
        FederalInstitutionDb db = new FederalInstitutionDb();
        GraphQL<FederalInstitutionDb> gql;

        HomeController()
        {
            var schema = GraphQL<FederalInstitutionDb>.CreateDefaultSchema(() => new FederalInstitutionDb());

            schema.AddType<FederalInstitution>().AddAllFields();
            //schema.AddType<DepartmentDB>().AddAllFields();

            var deptDB = schema.AddType<DepartmentDB>();

            deptDB.AddField(d => d.Name);
            deptDB.AddField(d => d.Department);
            schema.AddListField("federalInstitutions", db => db.FederalInstitutions);
            schema.AddListField("departmentDbs", db => db.DepartmentDBs);
            schema.Complete();

            gql = new GraphQL<FederalInstitutionDb>(schema);
        }

        [HttpGet]
        public string Get()
        {
            var query = @"{
                departmentDbs {
                name                
            }
            }";
            var dict = gql.ExecuteQuery(query);


            return JsonConvert.SerializeObject(dict, Formatting.Indented);
        }
    }
}
