using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IRS_FederalInstitutionQL.Models
{
    public class FederalInstitutionFilter
    {
        public int? RSSDID { get; set; }
        public string searchTxt { get; set; }
        public Boolean isStartsWith { get; set; }
        public string[] selectedStates { get; set; }
        public int[] selectedTypes { get; set; }
        public Boolean searchBankingTypes { get; set; }
        public Boolean searchHoldingCompanies { get; set; }
    }
}