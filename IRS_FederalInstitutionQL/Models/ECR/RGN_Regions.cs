namespace IRS_FederalInstitutionQL.Models.ECR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RGN_Regions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RGN_Regions()
        {
            IST_InstnXRegions = new HashSet<IST_InstnXRegions>();
        }

        [Key]
        [StringLength(16)]
        public string RGN_Code { get; set; }

        [Required]
        [StringLength(16)]
        public string RGN_StateCode { get; set; }

        [StringLength(64)]
        public string RGN_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IST_InstnXRegions> IST_InstnXRegions { get; set; }
    }
}
