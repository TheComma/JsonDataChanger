namespace JSON_Converted
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AvadConfiguratorDataContext : DbContext
    {
        public AvadConfiguratorDataContext()
            : base("name=AvadConfiguratorDataContext")
        {
        }

        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<UserSetups> UserSetups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
                .Property(e => e.CurrencyId)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductGroupId)
                .IsUnicode(false);

            modelBuilder.Entity<UserSetups>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<UserSetups>()
                .Property(e => e.Data)
                .IsUnicode(false);

            modelBuilder.Entity<UserSetups>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);
        }
    }
}
