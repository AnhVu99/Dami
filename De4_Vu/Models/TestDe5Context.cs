using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace De4_Vu.Models;

public partial class TestDe5Context : DbContext
{
    public TestDe5Context()
    {
    }

    public TestDe5Context(DbContextOptions<TestDe5Context> options)
        : base(options)
    {
    }

    public virtual DbSet<SlTblCustomerList> SlTblCustomerLists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-QCUIUKV\\SQLEXPRESS1;Database=Test_De5;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SlTblCustomerList>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__SL_tblCu__A4AE64B87F60ED59");

            entity.ToTable("SL_tblCustomerList");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CustomerID");
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.ContactPerson).HasMaxLength(60);
            entity.Property(e => e.CustomerName).HasMaxLength(250);
            entity.Property(e => e.DebtLimit).HasColumnType("money");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TaxCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
