﻿// <auto-generated />
using System;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240612122144_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dranga_Marius_M531.Models.Adresa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Apartament")
                        .HasColumnType("int");

                    b.Property<int>("Numar")
                        .HasColumnType("int");

                    b.Property<string>("Strada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Dranga_Marius_M531.Models.Banca", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdresaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("DobandaGenerala")
                        .HasColumnType("float");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdresaId");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("Dranga_Marius_M531.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdresaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BancaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataNasterii")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipCredit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdresaId");

                    b.HasIndex("BancaId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Dranga_Marius_M531.Models.Banca", b =>
                {
                    b.HasOne("Dranga_Marius_M531.Models.Adresa", "Adresa")
                        .WithMany()
                        .HasForeignKey("AdresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adresa");
                });

            modelBuilder.Entity("Dranga_Marius_M531.Models.Client", b =>
                {
                    b.HasOne("Dranga_Marius_M531.Models.Adresa", "Adresa")
                        .WithMany()
                        .HasForeignKey("AdresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dranga_Marius_M531.Models.Banca", null)
                        .WithMany("Clienti")
                        .HasForeignKey("BancaId");

                    b.Navigation("Adresa");
                });

            modelBuilder.Entity("Dranga_Marius_M531.Models.Banca", b =>
                {
                    b.Navigation("Clienti");
                });
#pragma warning restore 612, 618
        }
    }
}