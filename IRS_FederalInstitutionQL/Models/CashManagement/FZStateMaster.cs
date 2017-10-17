namespace IRS_FederalInstitutionQL.Models.CashManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FZStateMaster")]
    public partial class FZStateMaster
    {
        [Key]
        [StringLength(2)]
        public string StateID { get; set; }

        [StringLength(50)]
        public string StateName { get; set; }
    }
}
