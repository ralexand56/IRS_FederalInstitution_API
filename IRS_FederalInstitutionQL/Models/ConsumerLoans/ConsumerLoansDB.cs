namespace IRS_FederalInstitutionQL.Models.ConsumerLoans
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ConsumerLoansDB : DbContext
    {
        public ConsumerLoansDB()
            : base("name=ConsumerLoansDB")
        {
        }

        public virtual DbSet<HoldingCompany> HoldingCompanies { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<InstitutionType> InstitutionTypes { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<State> States { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoldingCompany>()
                .Property(e => e.HCName)
                .IsUnicode(false);

            modelBuilder.Entity<HoldingCompany>()
                .Property(e => e.HCAlias)
                .IsUnicode(false);

            modelBuilder.Entity<HoldingCompany>()
                .Property(e => e.FDICNo)
                .IsUnicode(false);

            modelBuilder.Entity<HoldingCompany>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<HoldingCompany>()
                .Property(e => e.State)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoldingCompany>()
                .Property(e => e.Assets)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HoldingCompany>()
                .Property(e => e.Deposits)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Institution>()
                .Property(e => e.InstitutionName)
                .IsUnicode(false);

            modelBuilder.Entity<Institution>()
                .Property(e => e.StateCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Institution>()
                .Property(e => e.BankID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InstitutionType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<InstitutionType>()
                .Property(e => e.InstTypeCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InstitutionType>()
                .HasMany(e => e.Institutions)
                .WithRequired(e => e.InstitutionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Region>()
                .Property(e => e.StateCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.StateCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.statename)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.repcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.abrev)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.loantypes)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.loanname)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .HasMany(e => e.Institutions)
                .WithRequired(e => e.State)
                .WillCascadeOnDelete(false);
        }
    }
}
