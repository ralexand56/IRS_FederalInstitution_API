namespace IRS_FederalInstitutionQL.Models.Deposit
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOLDING_COMPANY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOLDING_COMPANY()
        {
            BANKs = new HashSet<BANK>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal HC_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string HC_NAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? HC_CREATED_BY { get; set; }

        public DateTime? HC_CREATED_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? HC_MOD_BY { get; set; }

        public DateTime? HC_MOD_DATE { get; set; }

        [StringLength(255)]
        public string HC_CITY { get; set; }

        [StringLength(4)]
        public string HC_STATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? HC_ASSETS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? HC_DEPOSITS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? HC_FDIC_NUMBER { get; set; }

        public Guid ROWID { get; set; }

        [StringLength(100)]
        public string HC_KEY_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANK> BANKs { get; set; }
    }
}
