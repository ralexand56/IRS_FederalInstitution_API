namespace IRS_FederalInstitutionQL.Models.Deposit
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANK")]
    public partial class BANK
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal BA_ID { get; set; }

        [Required]
        [StringLength(1)]
        public string BA_IS_CUSTOMER { get; set; }

        [Required]
        [StringLength(1)]
        public string BA_ACTIVE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BA_LOCATION { get; set; }

        [Required]
        [StringLength(100)]
        public string BA_FIRM_NAME { get; set; }

        [StringLength(100)]
        public string BA_FIRM_ADDR1 { get; set; }

        [StringLength(100)]
        public string BA_FIRM_ADDR2 { get; set; }

        [Required]
        [StringLength(100)]
        public string BA_CITY { get; set; }

        [Required]
        [StringLength(2)]
        public string BA_STATE { get; set; }

        [StringLength(10)]
        public string BA_ZIP { get; set; }

        [StringLength(20)]
        public string BA_MAIN_PHONE { get; set; }

        [StringLength(5)]
        public string BA_MAIN_EXT { get; set; }

        [StringLength(20)]
        public string BA_MAIN_FAX { get; set; }

        [Required]
        [StringLength(1)]
        public string BA_INST_TYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BA_PRIORITY { get; set; }

        [StringLength(2000)]
        public string BA_RSRCH_NOTES { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BA_CREATED_BY { get; set; }

        public DateTime BA_CREATED_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BA_MOD_BY { get; set; }

        public DateTime? BA_MOD_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BA_BASIS_MAX_OFFSET { get; set; }

        public DateTime BA_DATA_DUE { get; set; }

        [Required]
        [StringLength(7)]
        public string BA_STATUS { get; set; }

        [StringLength(100)]
        public string BA_PRICING_REGION { get; set; }

        public DateTime? BA_DATE_LAST_COLL { get; set; }

        public DateTime? BA_ONLINE_TIME { get; set; }

        [Required]
        [StringLength(1)]
        public string BA_LAST_COLL_MODE { get; set; }

        [StringLength(100)]
        public string BA_ACCT_MGR { get; set; }

        [StringLength(200)]
        public string BA_BANK_FULLNAME { get; set; }

        [Required]
        [StringLength(1)]
        public string BA_HAS_PRODUCTS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BA_WKS_LOCK { get; set; }

        public DateTime? BA_LOCK_DATETIME { get; set; }

        [Required]
        [StringLength(4)]
        public string BA_TERMTIER_SORT { get; set; }

        [Required]
        [StringLength(1)]
        public string BA_DIRECT { get; set; }

        [Required]
        [StringLength(1)]
        public string BA_PROMO_ONLY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BA_LAST_DATAENTRY_BY { get; set; }

        [StringLength(500)]
        public string BA_STATES_USED_IN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BA_HC_ID { get; set; }

        [StringLength(32)]
        public string BA_LAST_PROC { get; set; }

        [StringLength(100)]
        public string BA_STD_ALIAS { get; set; }

        [Required]
        [StringLength(1)]
        public string BA_DIR_NOPROMOS { get; set; }

        [Required]
        [StringLength(1)]
        public string BA_STICKY_TIMES { get; set; }

        [Required]
        [StringLength(1)]
        public string BA_CLIENT { get; set; }

        [StringLength(100)]
        public string BA_FDIC_CERT { get; set; }

        [StringLength(20)]
        public string BA_I_CODE { get; set; }

        [StringLength(20)]
        public string BA_DATABASE { get; set; }

        [StringLength(7)]
        public string BA_CHKOUT_STATUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BA_CHKOUT_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BA_CHKOUT_AT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BA_CHKIN_BY { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BA_CHKIN_AT { get; set; }

        public Guid? ROWID { get; set; }

        [StringLength(100)]
        public string BA_REGULATORY_ID { get; set; }

        [StringLength(100)]
        public string BA_KEY_ID { get; set; }

        [StringLength(100)]
        public string BA_TOP_HC_REG_ID { get; set; }

        public virtual HOLDING_COMPANY HOLDING_COMPANY { get; set; }
    }
}
