namespace IRS_FederalInstitutionQL.Models.FederalInstitution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FederalEntityType")]
    public partial class FederalEntityType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FederalEntityType()
        {
            //FederalInstitutions = new HashSet<FederalInstitution>();
        }

        [Key]
        [StringLength(4)]
        public string FederalEntityTypeCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<FederalInstitution> FederalInstitutions { get; set; }
    }
}
