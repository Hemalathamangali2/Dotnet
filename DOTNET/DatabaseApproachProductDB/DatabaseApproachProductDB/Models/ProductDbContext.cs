using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseApproachProductDB.Models;

public partial class ProductDbContext : DbContext
{
    public ProductDbContext()
    {
    }

    public ProductDbContext(DbContextOptions<ProductDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BillTbl> BillTbls { get; set; }

    public virtual DbSet<CustomerTbl> CustomerTbls { get; set; }

    public virtual DbSet<OrderItemId> OrderItemIds { get; set; }

    public virtual DbSet<OrderTbl> OrderTbls { get; set; }

    public virtual DbSet<ProductTbl> ProductTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=HP\\HEMA;Database=ProductDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BillTbl>(entity =>
        {
            entity.HasKey(e => e.BillId);

            entity.ToTable("BillTbl");

            entity.Property(e => e.BillId).ValueGeneratedNever();
            entity.Property(e => e.OrderId).HasColumnName("OrderID");

            entity.HasOne(d => d.Order).WithMany(p => p.BillTbls)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BillTbl_OrderTbl");
        });

        modelBuilder.Entity<CustomerTbl>(entity =>
        {
            entity.HasKey(e => e.CustomerId);

            entity.ToTable("CustomerTbl");

            entity.Property(e => e.CustomerId).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrderItemId>(entity =>
        {
            entity.HasKey(e => e.OrderItemId1);

            entity.ToTable("OrderItemId");

            entity.Property(e => e.OrderItemId1)
                .ValueGeneratedNever()
                .HasColumnName("OrderItemId");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItemIds)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderItemId_OrderTbl");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderItemIds)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderItemId_ProductTbl");
        });

        modelBuilder.Entity<OrderTbl>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.ToTable("OrderTbl");

            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("OrderID");

            entity.HasOne(d => d.Customer).WithMany(p => p.OrderTbls)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderTbl_CustomerTbl");
        });

        modelBuilder.Entity<ProductTbl>(entity =>
        {
            entity.HasKey(e => e.ProductId);

            entity.ToTable("ProductTbl");

            entity.Property(e => e.ProductId).ValueGeneratedNever();
            entity.Property(e => e.ProductName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProductPrice).HasColumnType("decimal(18, 0)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
