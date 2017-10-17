namespace IRS_FederalInstitutionQL.Models.ConsumerLoans
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Institution")]
    public partial class Institution
    {
        public int InstitutionID { get; set; }

        [Required]
        [StringLength(150)]
        public string InstitutionName { get; set; }

        public int InstitutionTypeID { get; set; }

        public int? InstitutionGroupID { get; set; }

        [Required]
        [StringLength(2)]
        public string StateCode { get; set; }

        public bool IsActive { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreateDate { get; set; }

        public int? CreatedByUserID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifyDate { get; set; }

        public int? ModifiedByUserID { get; set; }

        public int? HCID { get; set; }

        [Required]
        [StringLength(7)]
        public string BankID { get; set; }

        public int? VEH { get; set; }

        public int? PELOC { get; set; }

        public int? PELOAN { get; set; }

        public int? HELOC { get; set; }

        public int? HELOAN { get; set; }

        public int? MANUF { get; set; }

        public int? GlobalInstID { get; set; }

        public int? RSSDID { get; set; }

        public virtual HoldingCompany HoldingCompany { get; set; }

        public virtual InstitutionType InstitutionType { get; set; }

        public virtual State State { get; set; }
    }
}
