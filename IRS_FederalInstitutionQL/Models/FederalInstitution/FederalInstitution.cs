namespace IRS_FederalInstitutionQL.Models.FederalInstitution
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FederalInstitution")]
    public partial class FederalInstitution
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FederalInstitution()
        {
            FederalInstitution1 = new HashSet<FederalInstitution>();
            FederalInstitution11 = new HashSet<FederalInstitution>();
            Institutions = new HashSet<Institution>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RSSDID { get; set; }

        public int? HeadRSSDID { get; set; }

        public int? HCRSSDID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(120)]
        public string FullName { get; set; }

        [Required]
        [StringLength(4)]
        public string FederalEntityTypeCode { get; set; }

        public int? CharterTypeID { get; set; }

        public int? EstablishmentTypeID { get; set; }

        [StringLength(40)]
        public string Street1 { get; set; }

        [StringLength(40)]
        public string Street2 { get; set; }

        [StringLength(25)]
        public string City { get; set; }

        [StringLength(2)]
        public string StateCode { get; set; }

        [StringLength(9)]
        public string ZipCode { get; set; }

        public int? CountryCode { get; set; }

        [StringLength(40)]
        public string CountryName { get; set; }

        [StringLength(40)]
        public string Province { get; set; }

        [StringLength(255)]
        public string Url { get; set; }

        [StringLength(6)]
        public string NAICS { get; set; }

        public int? FDICID { get; set; }

        public int? TaxID { get; set; }

        public int? IsHCCode { get; set; }

        public bool? IsSLHoldingCompany { get; set; }

        public int? BankCnt { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? CloseDate { get; set; }

        public int? TerminationReasonID { get; set; }

        public bool IsActive { get; set; }

        public bool IsBranch { get; set; }

        public int? TotalAssets { get; set; }

        [JsonIgnore]
        public virtual FederalEntityType FederalEntityType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FederalInstitution> FederalInstitution1 { get; set; }

        [JsonIgnore]
        public virtual FederalInstitution FederalInstitution2 { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FederalInstitution> FederalInstitution11 { get; set; }

        public virtual FederalInstitution FederalInstitution3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Institution> Institutions { get; set; }
    }
}
