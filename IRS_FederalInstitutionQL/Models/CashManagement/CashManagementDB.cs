namespace IRS_FederalInstitutionQL.Models.CashManagement
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CashManagementDB : DbContext
    {
        public CashManagementDB()
            : base("name=CashManagementDB")
        {
        }

        public virtual DbSet<FZInstMaster> FZInstMasters { get; set; }
        public virtual DbSet<FZRegionMaster> FZRegionMasters { get; set; }
        public virtual DbSet<FZStateMaster> FZStateMasters { get; set; }
        public virtual DbSet<FZInstTypeMaster> FZInstTypeMasters { get; set; }
        public virtual DbSet<FZInstXRegion> FZInstXRegions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FZInstMaster>()
                .HasMany(e => e.FZInstXRegions)
                .WithRequired(e => e.FZInstMaster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FZRegionMaster>()
                .HasMany(e => e.FZInstXRegions)
                .WithRequired(e => e.FZRegionMaster)
                .WillCascadeOnDelete(false);
        }
    }
}
