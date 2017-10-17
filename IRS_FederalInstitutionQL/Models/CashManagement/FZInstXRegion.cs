namespace IRS_FederalInstitutionQL.Models.CashManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FZInstXRegion")]
    public partial class FZInstXRegion
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string InstID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string RegionID { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public bool? IsDeleted { get; set; }

        [StringLength(100)]
        public string DeletedBy { get; set; }

        public DateTime? DeletedDate { get; set; }

        public virtual FZInstMaster FZInstMaster { get; set; }

        public virtual FZRegionMaster FZRegionMaster { get; set; }
    }
}
