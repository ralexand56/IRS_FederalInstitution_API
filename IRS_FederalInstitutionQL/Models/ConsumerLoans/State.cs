namespace IRS_FederalInstitutionQL.Models.ConsumerLoans
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("State")]
    public partial class State
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public State()
        {
            Institutions = new HashSet<Institution>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int stateid { get; set; }

        [Key]
        [StringLength(2)]
        public string StateCode { get; set; }

        [StringLength(50)]
        public string statename { get; set; }

        [StringLength(14)]
        public string repcode { get; set; }

        public DateTime? arcv_date { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(2)]
        public string abrev { get; set; }

        [StringLength(15)]
        public string loantypes { get; set; }

        [StringLength(12)]
        public string loanname { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? update { get; set; }

        public int? UserID { get; set; }

        public bool? IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Institution> Institutions { get; set; }
    }
}
