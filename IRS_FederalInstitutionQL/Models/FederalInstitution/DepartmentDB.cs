namespace IRS_FederalInstitutionQL.Models.FederalInstitution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DepartmentDB")]
    public partial class DepartmentDB
    {
        [Key]
        public int DeptDBID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public int DeptID { get; set; }

        [StringLength(1500)]
        public string Connection { get; set; }

        [StringLength(150)]
        public string Server { get; set; }

        [StringLength(150)]
        public string DBName { get; set; }

        public bool HasRegions { get; set; }

        [StringLength(5)]
        public string Abbrev { get; set; }

        public bool IsActive { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        [StringLength(100)]
        public string EntityName { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastModified { get; set; }

        [StringLength(200)]
        public string LastModifiedUser { get; set; }

        public virtual Department Department { get; set; }
    }
}
