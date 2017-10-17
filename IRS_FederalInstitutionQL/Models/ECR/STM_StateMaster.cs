namespace IRS_FederalInstitutionQL.Models.ECR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STM_StateMaster
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string STM_StateCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string STM_StateDesc { get; set; }
    }
}
