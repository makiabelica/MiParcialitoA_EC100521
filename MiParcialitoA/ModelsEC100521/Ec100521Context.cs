using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MiParcialitoA.ModelsEC100521;

public partial class Ec100521Context : DbContext
{
    public Ec100521Context()
    {
    }

    public Ec100521Context(DbContextOptions<Ec100521Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Municipio> Municipios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost; Database=EC100521; User Id=sa;Password=p4nC0n-Q3s0!;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DepaId)
                .HasMaxLength(255)
                .HasColumnName("depa_id");
            entity.Property(e => e.DepaNombre)
                .HasMaxLength(255)
                .HasColumnName("depa_nombre");
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DepaId)
                .HasMaxLength(255)
                .HasColumnName("depa_id");
            entity.Property(e => e.MuniId)
                .HasMaxLength(255)
                .HasColumnName("muni_id");
            entity.Property(e => e.MuniNombre)
                .HasMaxLength(255)
                .HasColumnName("muni_nombre");
            entity.Property(e => e.MunidepaId).HasColumnName("munidepa_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
