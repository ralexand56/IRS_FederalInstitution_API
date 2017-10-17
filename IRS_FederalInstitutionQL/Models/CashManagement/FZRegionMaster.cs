namespace IRS_FederalInstitutionQL.Models.CashManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FZRegionMaster")]
    public partial class FZRegionMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FZRegionMaster()
        {
            FZInstXRegions = new HashSet<FZInstXRegion>();
        }

        [Key]
        [StringLength(10)]
        public string RegionID { get; set; }

        [StringLength(10)]
        public string LegacyID { get; set; }

        [StringLength(100)]
        public string RegionName { get; set; }

        [StringLength(2)]
        public string StateID { get; set; }

        public int? DisplayOrder { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool? IsDeleted { get; set; }

        [StringLength(100)]
        public string DeletedBy { get; set; }

        public DateTime? DeletedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FZInstXRegion> FZInstXRegions { get; set; }
    }
}
