namespace IRS_FederalInstitutionQL.Models.FederalInstitution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InstitutionType")]
    public partial class InstitutionType
    {
        public int InstitutionTypeID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }
    }
}
