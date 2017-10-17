namespace IRS_FederalInstitutionQL.Models.ECR
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ECRDB : DbContext
    {
        public ECRDB()
            : base("name=ECRDb")
        {
        }

        public virtual DbSet<INS_Institutions> INS_Institutions { get; set; }
        public virtual DbSet<RGN_Regions> RGN_Regions { get; set; }
        public virtual DbSet<IST_InstnXRegions> IST_InstnXRegions { get; set; }
        public virtual DbSet<STM_StateMaster> STM_StateMaster { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<INS_Institutions>()
                .Property(e => e.INS_InstName)
                .IsUnicode(false);

            modelBuilder.Entity<INS_Institutions>()
                .Property(e => e.INS_Notes)
                .IsUnicode(false);

            modelBuilder.Entity<INS_Institutions>()
                .Property(e => e.INS_DueBy)
                .IsUnicode(false);

            modelBuilder.Entity<INS_Institutions>()
                .Property(e => e.INS_StateCovered)
                .IsUnicode(false);

            modelBuilder.Entity<INS_Institutions>()
                .Property(e => e.INS_Website)
                .IsUnicode(false);

            modelBuilder.Entity<INS_Institutions>()
                .Property(e => e.INS_RatesInfo)
                .IsUnicode(false);

            modelBuilder.Entity<INS_Institutions>()
                .Property(e => e.INS_Active)
                .IsUnicode(false);

            modelBuilder.Entity<INS_Institutions>()
                .Property(e => e.INS_TZone)
                .IsUnicode(false);

            modelBuilder.Entity<INS_Institutions>()
                .Property(e => e.INS_Difficulty)
                .IsUnicode(false);

            modelBuilder.Entity<INS_Institutions>()
                .Property(e => e.INS_Client)
                .IsUnicode(false);

            modelBuilder.Entity<INS_Institutions>()
                .Property(e => e.INS_Type)
                .IsUnicode(false);

            modelBuilder.Entity<INS_Institutions>()
                .Property(e => e.INS_CrtBy)
                .IsUnicode(false);

            modelBuilder.Entity<INS_Institutions>()
                .Property(e => e.INS_ModBy)
                .IsUnicode(false);

            modelBuilder.Entity<INS_Institutions>()
                .HasMany(e => e.IST_InstnXRegions)
                .WithRequired(e => e.INS_Institutions)
                .HasForeignKey(e => e.IST_INS_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RGN_Regions>()
                .Property(e => e.RGN_Code)
                .IsUnicode(false);

            modelBuilder.Entity<RGN_Regions>()
                .Property(e => e.RGN_StateCode)
                .IsUnicode(false);

            modelBuilder.Entity<RGN_Regions>()
                .Property(e => e.RGN_Name)
                .IsUnicode(false);

            modelBuilder.Entity<RGN_Regions>()
                .HasMany(e => e.IST_InstnXRegions)
                .WithRequired(e => e.RGN_Regions)
                .HasForeignKey(e => e.IST_RGN_Code)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IST_InstnXRegions>()
                .Property(e => e.IST_RGN_Code)
                .IsUnicode(false);

            modelBuilder.Entity<STM_StateMaster>()
                .Property(e => e.STM_StateCode)
                .IsUnicode(false);

            modelBuilder.Entity<STM_StateMaster>()
                .Property(e => e.STM_StateDesc)
                .IsUnicode(false);
        }
    }
}
