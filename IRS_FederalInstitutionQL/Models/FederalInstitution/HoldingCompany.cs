namespace IRS_FederalInstitutionQL.Models.FederalInstitution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoldingCompany")]
    public partial class HoldingCompany
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HCID { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(2)]
        public string StateCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Assets { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Deposits { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }

        public int InstitutionTypeID { get; set; }

        public int? FDICNo { get; set; }

        public int? RRSDID { get; set; }
    }
}
