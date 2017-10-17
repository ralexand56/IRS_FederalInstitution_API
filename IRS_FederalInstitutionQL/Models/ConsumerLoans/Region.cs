namespace IRS_FederalInstitutionQL.Models.ConsumerLoans
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Region")]
    public partial class Region
    {
        public int RegionID { get; set; }

        [StringLength(75)]
        public string RegionName { get; set; }

        [StringLength(2)]
        public string StateCode { get; set; }
    }
}
