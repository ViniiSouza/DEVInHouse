using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DatabaseFirst.Models;
using Microsoft.Extensions.Configuration;

namespace DatabaseFirst.Context
{
    public partial class ClinicaVeterinariaContext : DbContext
    {
        public ClinicaVeterinariaContext()
        {
        }

        public ClinicaVeterinariaContext(DbContextOptions<ClinicaVeterinariaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Animal> Animals { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Consulta> Consulta { get; set; } = null!;
        public virtual DbSet<Especie> Especies { get; set; } = null!;
        public virtual DbSet<Exame> Exames { get; set; } = null!;
        public virtual DbSet<Tratamento> Tratamentos { get; set; } = null!;
        public virtual DbSet<Veterinario> Veterinarios { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>(entity =>
            {
                entity.ToTable("Animal");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdEspecie).HasColumnName("idEspecie");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Animals)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__Animal__idClient__38996AB5");

                entity.HasOne(d => d.IdEspecieNavigation)
                    .WithMany(p => p.Animals)
                    .HasForeignKey(d => d.IdEspecie)
                    .HasConstraintName("FK__Animal__idEspeci__3C69FB99");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cep).HasColumnName("CEP");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco).HasMaxLength(200);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone).HasMaxLength(35);
            });

            modelBuilder.Entity<Consulta>(entity =>
            {
                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.Historico).HasMaxLength(500);

                entity.Property(e => e.IdTratamento).HasColumnName("idTratamento");

                entity.Property(e => e.IdVeterinario).HasColumnName("idVeterinario");

                entity.HasOne(d => d.IdTratamentoNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.IdTratamento)
                    .HasConstraintName("FK__Consulta__idTrat__440B1D61");

                entity.HasOne(d => d.IdVeterinarioNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.IdVeterinario)
                    .HasConstraintName("FK__Consulta__idVete__44FF419A");
            });

            modelBuilder.Entity<Especie>(entity =>
            {
                entity.ToTable("Especie");

                entity.Property(e => e.Descricao).HasMaxLength(250);

                entity.Property(e => e.IdAnimal).HasColumnName("idAnimal");

                entity.HasOne(d => d.IdAnimalNavigation)
                    .WithMany(p => p.Especies)
                    .HasForeignKey(d => d.IdAnimal)
                    .HasConstraintName("FK__Especie__idAnima__3B75D760");
            });

            modelBuilder.Entity<Exame>(entity =>
            {
                entity.ToTable("Exame");

                entity.Property(e => e.Descricao).HasMaxLength(250);

                entity.Property(e => e.IdConsulta).HasColumnName("idConsulta");

                entity.HasOne(d => d.IdConsultaNavigation)
                    .WithMany(p => p.Exames)
                    .HasForeignKey(d => d.IdConsulta)
                    .HasConstraintName("FK__Exame__idConsult__48CFD27E");
            });

            modelBuilder.Entity<Tratamento>(entity =>
            {
                entity.ToTable("Tratamento");

                entity.Property(e => e.DataFinal).HasColumnType("date");

                entity.Property(e => e.DataInicial).HasColumnType("date");

                entity.Property(e => e.IdAnimal).HasColumnName("idAnimal");

                entity.HasOne(d => d.IdAnimalNavigation)
                    .WithMany(p => p.Tratamentos)
                    .HasForeignKey(d => d.IdAnimal)
                    .HasConstraintName("FK__Tratament__idAni__3F466844");
            });

            modelBuilder.Entity<Veterinario>(entity =>
            {
                entity.ToTable("Veterinario");

                entity.Property(e => e.Endereco).HasMaxLength(250);

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone).HasMaxLength(35);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
