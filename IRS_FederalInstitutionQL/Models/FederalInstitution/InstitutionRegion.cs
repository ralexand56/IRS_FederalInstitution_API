namespace IRS_FederalInstitutionQL.Models.FederalInstitution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InstitutionRegion")]
    public partial class InstitutionRegion
    {
        public int InstitutionRegionID { get; set; }

        public int InstitutionID { get; set; }

        public int RegionID { get; set; }

        public virtual Region Region { get; set; }
    }
}
