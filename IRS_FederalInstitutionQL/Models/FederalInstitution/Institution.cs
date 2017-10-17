namespace IRS_FederalInstitutionQL.Models.FederalInstitution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Institution
    {
        [Key]
        [StringLength(102)]
        public string InstitutionID { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(2)]
        public string StateCode { get; set; }

        public int InstitutionTypeID { get; set; }

        public string Region { get; set; }

        public int? RSSDID { get; set; }

        public int? HCID { get; set; }

        public int DeptDBID { get; set; }

        public virtual FederalInstitution FederalInstitution { get; set; }

        public virtual InstitutionType InstitutionType { get; set; }
    }
}
