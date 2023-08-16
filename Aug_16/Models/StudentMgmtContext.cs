using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StudentDetailsDBF.Models;

namespace Jwt.Models;

public partial class StudentMgmtContext : DbContext
{
    public StudentMgmtContext()
    {
    }

    public StudentMgmtContext(DbContextOptions<StudentMgmtContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }
    public object Users { get; internal set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("data source = .\\SQLEXPRESS; initial catalog = StudentMgmt; integrated security=SSPI; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Rollno);

            entity.Property(e => e.Rollno).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
