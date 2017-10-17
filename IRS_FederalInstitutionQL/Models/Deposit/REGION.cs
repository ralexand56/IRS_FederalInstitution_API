namespace IRS_FederalInstitutionQL.Models.Deposit
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REGIONS")]
    public partial class REGION
    {
        [StringLength(6)]
        public string REGION_ID { get; set; }

        [Column("REGION")]
        [StringLength(60)]
        public string REGION1 { get; set; }

        [StringLength(2)]
        public string STATE { get; set; }

        [Key]
        public Guid ROWID { get; set; }
    }
}
