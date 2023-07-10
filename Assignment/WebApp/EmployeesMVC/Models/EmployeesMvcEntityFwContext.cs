using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EmployeesMVC.Models;

public partial class EmployeesMvcEntityFwContext : DbContext
{
    public EmployeesMvcEntityFwContext()
    {
    }

    public EmployeesMvcEntityFwContext(DbContextOptions<EmployeesMvcEntityFwContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmpDatum> EmpData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MsSqlLocalDb;Initial Catalog=EmployeesMVC_EntityFW;Integrated Security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmpDatum>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__EmpData__7AD04F1115006A3E");

            entity.Property(e => e.EmployeeId).ValueGeneratedNever();
            entity.Property(e => e.EmployeeCity)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.EmployeeDob)
                .HasColumnType("date")
                .HasColumnName("EmployeeDOB");
            entity.Property(e => e.EmployeeGender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.EmployeeSalary).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
