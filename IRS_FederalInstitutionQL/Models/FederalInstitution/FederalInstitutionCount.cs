using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IRS_FederalInstitutionQL.Models.FederalInstitution
{
    public class FederalInstitutionCount
    {
        [Key]
        public int RSSDID { get; set; }
        public DepartmentDB DepartmentDB { get; set; }
        public int Count { get; set; }
    }
}