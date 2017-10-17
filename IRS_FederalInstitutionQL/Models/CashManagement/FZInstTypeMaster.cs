namespace IRS_FederalInstitutionQL.Models.CashManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FZInstTypeMaster")]
    public partial class FZInstTypeMaster
    {
        [Key]
        [StringLength(50)]
        public string InstTypeID { get; set; }

        [StringLength(100)]
        public string InstTypeName { get; set; }
    }
}
