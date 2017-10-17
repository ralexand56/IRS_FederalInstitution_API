using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IRS_FederalInstitutionQL.Models
{
    public class Institution
    {
        public string InstitutionID { get; set; }
        public string CustomID { get; set; }
        public string Name { get; set; }
        public string StateCode { get; set; }
        public int InstitutionTypeID { get; set; }
        public string Region { get; set; }
        public int? RSSDID { get; set; }
        public int? HCID { get; set; }
        public int DeptDBID { get; set; }
        public FederalInstitution.FederalInstitution FederalInstitution { get; set; }
        //public FederalInstitution.DepartmentDB DepartmentDB { get; set; }
        public FederalInstitution.InstitutionType InstitutionType { get; set; }
    }
}