namespace IRS_FederalInstitutionQL.Models.ECR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IST_InstnXRegions
    {
        [Key]
        [Column(Order = 0)]
        public int IST_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IST_INS_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(16)]
        public string IST_RGN_Code { get; set; }

        public virtual INS_Institutions INS_Institutions { get; set; }

        public virtual RGN_Regions RGN_Regions { get; set; }
    }
}
