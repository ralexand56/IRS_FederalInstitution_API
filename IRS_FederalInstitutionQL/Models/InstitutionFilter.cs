using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IRS_FederalInstitutionQL.Models
{
    public class InstitutionFilter
    {
        public int deptDBID { get; set; }
        public int RSSDID { get; set; }
        public string searchTxt { get; set; }
        public Boolean isStartsWith { get; set; }
        public string selectedAssignmentFilter { get; set; }
        public string[] selectedStates { get; set; }
        public int[] selectedTypes { get; set; }
    }
}