namespace IRS_FederalInstitutionQL.Models.Deposit
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STATES")]
    public partial class STATE
    {
        [StringLength(2)]
        public string StateID { get; set; }

        [StringLength(50)]
        public string StateName { get; set; }
    }
}
