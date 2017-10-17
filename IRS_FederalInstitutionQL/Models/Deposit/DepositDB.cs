namespace IRS_FederalInstitutionQL.Models.Deposit
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DepositDB : DbContext
    {
        public DepositDB()
            : base("name=DepositDB")
        {
        }

        public virtual DbSet<BANK> BANKs { get; set; }
        public virtual DbSet<HOLDING_COMPANY> HOLDING_COMPANY { get; set; }
        public virtual DbSet<REGION> REGIONS { get; set; }
        public virtual DbSet<STATE> STATES { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_IS_CUSTOMER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_ACTIVE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_LOCATION)
                .HasPrecision(2, 0);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_FIRM_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_FIRM_ADDR1)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_FIRM_ADDR2)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_CITY)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_STATE)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_ZIP)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_MAIN_PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_MAIN_EXT)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_MAIN_FAX)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_INST_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_PRIORITY)
                .HasPrecision(1, 0);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_RSRCH_NOTES)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_CREATED_BY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_MOD_BY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_BASIS_MAX_OFFSET)
                .HasPrecision(10, 5);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_PRICING_REGION)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_LAST_COLL_MODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_ACCT_MGR)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_BANK_FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_HAS_PRODUCTS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_WKS_LOCK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_TERMTIER_SORT)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_DIRECT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_PROMO_ONLY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_LAST_DATAENTRY_BY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_STATES_USED_IN)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_HC_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_LAST_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_STD_ALIAS)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_DIR_NOPROMOS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_STICKY_TIMES)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_CLIENT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_FDIC_CERT)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_I_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_DATABASE)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_CHKOUT_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_CHKOUT_BY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_CHKIN_BY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_REGULATORY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_KEY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<BANK>()
                .Property(e => e.BA_TOP_HC_REG_ID)
                .IsUnicode(false);

            modelBuilder.Entity<HOLDING_COMPANY>()
                .Property(e => e.HC_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOLDING_COMPANY>()
                .Property(e => e.HC_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<HOLDING_COMPANY>()
                .Property(e => e.HC_CREATED_BY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOLDING_COMPANY>()
                .Property(e => e.HC_MOD_BY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOLDING_COMPANY>()
                .Property(e => e.HC_CITY)
                .IsUnicode(false);

            modelBuilder.Entity<HOLDING_COMPANY>()
                .Property(e => e.HC_STATE)
                .IsUnicode(false);

            modelBuilder.Entity<HOLDING_COMPANY>()
                .Property(e => e.HC_ASSETS)
                .HasPrecision(30, 0);

            modelBuilder.Entity<HOLDING_COMPANY>()
                .Property(e => e.HC_DEPOSITS)
                .HasPrecision(30, 0);

            modelBuilder.Entity<HOLDING_COMPANY>()
                .Property(e => e.HC_FDIC_NUMBER)
                .HasPrecision(30, 0);

            modelBuilder.Entity<HOLDING_COMPANY>()
                .Property(e => e.HC_KEY_ID)
                .IsUnicode(false);

            modelBuilder.Entity<HOLDING_COMPANY>()
                .HasMany(e => e.BANKs)
                .WithOptional(e => e.HOLDING_COMPANY)
                .HasForeignKey(e => e.BA_HC_ID);

            modelBuilder.Entity<REGION>()
                .Property(e => e.REGION_ID)
                .IsUnicode(false);

            modelBuilder.Entity<REGION>()
                .Property(e => e.REGION1)
                .IsUnicode(false);

            modelBuilder.Entity<REGION>()
                .Property(e => e.STATE)
                .IsUnicode(false);
        }
    }
}
