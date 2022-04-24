using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DatabaseFirst_11.Models;

namespace DatabaseFirst_11.Context
{
    public partial class BancoContext : DbContext
    {
        public BancoContext()
        {
        }

        public BancoContext(DbContextOptions<BancoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<ContaCorrente> ContaCorrentes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-OF89FLJ\\SQLEXPRESS;Database=BANCO;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente");

                entity.Property(e => e.DataNascimento).HasColumnType("datetime");

                entity.Property(e => e.IdContaCorrente).HasColumnName("idContaCorrente");

                entity.Property(e => e.Nome).HasMaxLength(50);

                entity.Property(e => e.Sobrenome).HasMaxLength(100);

                entity.HasOne(d => d.IdContaCorrenteNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdContaCorrente)
                    .HasConstraintName("FK__Cliente__idConta__5CD6CB2B");
            });

            modelBuilder.Entity<ContaCorrente>(entity =>
            {
                entity.ToTable("ContaCorrente");

                entity.Property(e => e.Descricao).HasMaxLength(200);

                entity.Property(e => e.Rendimento)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
