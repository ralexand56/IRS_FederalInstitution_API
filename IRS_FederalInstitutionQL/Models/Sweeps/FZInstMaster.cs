namespace IRS_FederalInstitutionQL.Models.Sweeps
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FZInstMaster")]
    public partial class FZInstMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FZInstMaster()
        {
            FZInstXRegions = new HashSet<FZInstXRegion>();
        }

        public int? HCID { get; set; }

        [Key]
        [StringLength(10)]
        public string InstID { get; set; }

        [StringLength(100)]
        public string InstName { get; set; }

        [StringLength(50)]
        public string InstShortName { get; set; }

        [StringLength(250)]
        public string RegionsCovered { get; set; }

        [StringLength(100)]
        public string Phone { get; set; }

        public bool? IsClient { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsPortal { get; set; }

        [StringLength(20)]
        public string ResearcherID { get; set; }

        [StringLength(20)]
        public string AccountManagerID { get; set; }

        [StringLength(50)]
        public string InstTypeID { get; set; }

        [StringLength(20)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(20)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool? IsDeleted { get; set; }

        [StringLength(20)]
        public string DeletedBy { get; set; }

        public DateTime? DeletedDate { get; set; }

        [StringLength(1000)]
        public string InstNotes { get; set; }

        public DateTime? FeeSchedSB { get; set; }

        public DateTime? FeeSchedMM { get; set; }

        public DateTime? FeeSchedLC { get; set; }

        public DateTime? ResearcherModified { get; set; }

        [StringLength(1)]
        public string ResearcherToBeNotified { get; set; }

        public int? RSSDID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FZInstXRegion> FZInstXRegions { get; set; }
    }
}
