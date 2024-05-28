using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFDbFirstDemo;

public partial class HarmanProductsCatelogDbContext : DbContext
{
    public HarmanProductsCatelogDbContext()
    {
    }

    public HarmanProductsCatelogDbContext(DbContextOptions<HarmanProductsCatelogDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb;database=HarmanProductsCatelogDB;Trusted_Connection=True;MultipleActiveResultSets=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.CategoryName).HasMaxLength(50);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(NEXT VALUE FOR [PersonSequence])");
            entity.Property(e => e.AddressCity)
                .HasDefaultValue("")
                .HasColumnName("Address_City");
            entity.Property(e => e.AddressPostalCode)
                .HasDefaultValue("")
                .HasColumnName("Address_PostalCode");
            entity.Property(e => e.AddressState)
                .HasDefaultValue("")
                .HasColumnName("Address_State");
            entity.Property(e => e.AddressStreet)
                .HasDefaultValue("")
                .HasColumnName("Address_Street");
            entity.Property(e => e.Name).HasDefaultValue("");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_Products_CategoryId");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Brand).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Category).WithMany(p => p.Products).HasForeignKey(d => d.CategoryId);

            entity.HasMany(d => d.Suppliers).WithMany(p => p.ProductsProducts)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductSupplier",
                    r => r.HasOne<Supplier>().WithMany().HasForeignKey("SuppliersId"),
                    l => l.HasOne<Product>().WithMany().HasForeignKey("ProductsProductId"),
                    j =>
                    {
                        j.HasKey("ProductsProductId", "SuppliersId");
                        j.ToTable("ProductSupplier");
                        j.HasIndex(new[] { "SuppliersId" }, "IX_ProductSupplier_SuppliersId");
                        j.IndexerProperty<int>("ProductsProductId").HasColumnName("ProductsProductID");
                    });
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(NEXT VALUE FOR [PersonSequence])");
            entity.Property(e => e.AddressCity)
                .HasDefaultValue("")
                .HasColumnName("Address_City");
            entity.Property(e => e.AddressPostalCode)
                .HasDefaultValue("")
                .HasColumnName("Address_PostalCode");
            entity.Property(e => e.AddressState)
                .HasDefaultValue("")
                .HasColumnName("Address_State");
            entity.Property(e => e.AddressStreet)
                .HasDefaultValue("")
                .HasColumnName("Address_Street");
            entity.Property(e => e.Gstno).HasColumnName("GSTNo");
            entity.Property(e => e.Name).HasDefaultValue("");
        });
        modelBuilder.HasSequence("PersonSequence");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
