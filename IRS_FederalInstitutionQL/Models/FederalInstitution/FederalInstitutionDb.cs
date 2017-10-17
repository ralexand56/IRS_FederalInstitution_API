namespace IRS_FederalInstitutionQL.Models.FederalInstitution
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FederalInstitutionDb : DbContext
    {
        public FederalInstitutionDb()
            : base("name=FederalInsitution")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DepartmentDB> DepartmentDBs { get; set; }
        public virtual DbSet<FederalEntityType> FederalEntityTypes { get; set; }
        public virtual DbSet<FederalInstitution> FederalInstitutions { get; set; }
        public virtual DbSet<HoldingCompany> HoldingCompanies { get; set; }
        public virtual DbSet<InstitutionRegion> InstitutionRegions { get; set; }
        public virtual DbSet<InstitutionType> InstitutionTypes { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<State> States { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Department>()
            //    .HasMany(e => e.DepartmentDBs)
            //    .WithRequired(e => e.Department)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<FederalEntityType>()
            //    .HasMany(e => e.FederalInstitutions)
            //    .WithRequired(e => e.FederalEntityType)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<FederalInstitution>()
                .Property(e => e.StateCode)
                .IsFixedLength()
                .IsUnicode(false);

            //modelBuilder.Entity<FederalInstitution>()
            //    .HasMany(e => e.FederalInstitution1)
            //    .WithOptional(e => e.FederalInstitution2)
            //    .HasForeignKey(e => e.HeadRSSDID);

            //modelBuilder.Entity<FederalInstitution>()
            //    .HasMany(e => e.FederalInstitution11)
            //    .WithOptional(e => e.FederalInstitution3)
            //    .HasForeignKey(e => e.HCRSSDID);

            modelBuilder.Entity<HoldingCompany>()
                .Property(e => e.StateCode)
                .IsFixedLength();

            modelBuilder.Entity<HoldingCompany>()
                .Property(e => e.Assets)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HoldingCompany>()
                .Property(e => e.Deposits)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Region>()
                .Property(e => e.StateCode)
                .IsFixedLength();

            modelBuilder.Entity<Region>()
                .HasMany(e => e.InstitutionRegions)
                .WithRequired(e => e.Region)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<State>()
                .Property(e => e.StateCode)
                .IsFixedLength();
        }
    }
}
