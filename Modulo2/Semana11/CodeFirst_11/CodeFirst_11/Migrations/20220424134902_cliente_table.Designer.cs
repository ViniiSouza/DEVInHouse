﻿// <auto-generated />
using System;
using CodeFirst_11;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirst_11.Migrations
{
    [DbContext(typeof(ImobiliariaContext))]
    [Migration("20220424134902_cliente_table")]
    partial class cliente_table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodeFirst_11.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("CodeFirst_11.Models.Imovel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DescricaoCurta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescricaoLonga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.Property<int>("idCliente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("idCliente")
                        .IsUnique();

                    b.ToTable("Imovel");
                });

            modelBuilder.Entity("CodeFirst_11.Models.Imovel", b =>
                {
                    b.HasOne("CodeFirst_11.Models.Cliente", "Cliente")
                        .WithOne("Imovel")
                        .HasForeignKey("CodeFirst_11.Models.Imovel", "idCliente");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("CodeFirst_11.Models.Cliente", b =>
                {
                    b.Navigation("Imovel")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}