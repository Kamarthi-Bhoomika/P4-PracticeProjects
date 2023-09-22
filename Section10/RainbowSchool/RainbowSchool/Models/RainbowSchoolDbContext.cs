using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RainbowSchool.Models;

public partial class RainbowSchoolDbContext : DbContext
{
    public RainbowSchoolDbContext()
    {
    }

    public RainbowSchoolDbContext(DbContextOptions<RainbowSchoolDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:rainbowserver.database.windows.net,1433;Initial Catalog=RainbowSchoolDb;User Id=bhoomika; Password=bhoomi@123; Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Student__3214EC0765963EC8");

            entity.ToTable("Student");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PK__Subject__AC1BA3A82CA28733");

            entity.ToTable("Subject");

            entity.Property(e => e.SubjectId).ValueGeneratedNever();
            entity.Property(e => e.SubjectName).HasMaxLength(50);
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.TeacherId).HasName("PK__Teacher__EDF25964F47EBFE6");

            entity.ToTable("Teacher");

            entity.Property(e => e.TeacherId).ValueGeneratedNever();
            entity.Property(e => e.TeacherName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
