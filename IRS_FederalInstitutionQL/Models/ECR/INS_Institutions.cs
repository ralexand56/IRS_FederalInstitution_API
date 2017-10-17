namespace IRS_FederalInstitutionQL.Models.ECR
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_Institutions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INS_Institutions()
        {
            IST_InstnXRegions = new HashSet<IST_InstnXRegions>();
        }

        [Key]
        public int INS_ID { get; set; }

        [StringLength(96)]
        public string INS_InstName { get; set; }

        [StringLength(8000)]
        public string INS_Notes { get; set; }

        [StringLength(16)]
        public string INS_DueBy { get; set; }

        [StringLength(128)]
        public string INS_StateCovered { get; set; }

        [StringLength(128)]
        public string INS_Website { get; set; }

        [StringLength(128)]
        public string INS_RatesInfo { get; set; }

        [StringLength(8)]
        public string INS_Active { get; set; }

        [StringLength(16)]
        public string INS_TZone { get; set; }

        [StringLength(16)]
        public string INS_Difficulty { get; set; }

        [StringLength(8)]
        public string INS_Client { get; set; }

        [StringLength(8)]
        public string INS_Type { get; set; }

        public DateTime INS_CrtDt { get; set; }

        public DateTime INS_ModDt { get; set; }

        [Required]
        [StringLength(16)]
        public string INS_CrtBy { get; set; }

        [Required]
        [StringLength(16)]
        public string INS_ModBy { get; set; }

        public int INS_HCI_HCID { get; set; }

        public int? RSSDID { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IST_InstnXRegions> IST_InstnXRegions { get; set; }
    }
}
