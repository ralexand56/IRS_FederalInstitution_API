namespace IRS_FederalInstitutionQL.Models.ConsumerLoans
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoldingCompany")]
    public partial class HoldingCompany
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoldingCompany()
        {
            Institutions = new HashSet<Institution>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HCID { get; set; }

        [StringLength(150)]
        public string HCName { get; set; }

        [StringLength(150)]
        public string HCAlias { get; set; }

        public bool? Active { get; set; }

        [StringLength(1000)]
        public string ImageURL { get; set; }

        [StringLength(50)]
        public string FDICNo { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        public bool? Informatrix { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Assets { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Deposits { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Institution> Institutions { get; set; }
    }
}
