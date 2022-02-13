﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ogrenc.DataAccess;

#nullable disable

namespace Ogrenc.DataAccess.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20220212211129_reset2")]
    partial class reset2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ogrenc.Entities.Bolum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Bolums");
                });

            modelBuilder.Entity("Ogrenc.Entities.Ders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("IdBolum")
                        .HasColumnType("int");

                    b.Property<int?>("IdOgretimElemani")
                        .HasColumnType("int");

                    b.Property<int>("Kredi")
                        .HasColumnType("int");

                    b.Property<int>("Saat")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdBolum");

                    b.HasIndex("IdOgretimElemani");

                    b.ToTable("Ders");
                });

            modelBuilder.Entity("Ogrenc.Entities.Ogrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("AnaDalId")
                        .HasColumnType("int");

                    b.Property<string>("OgrenciNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("YanDalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnaDalId");

                    b.HasIndex("YanDalId");

                    b.ToTable("Ogrencis");
                });

            modelBuilder.Entity("Ogrenc.Entities.OgretimElemani", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SicilNo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("idBolum")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("idBolum");

                    b.ToTable("OgretimElemans");
                });

            modelBuilder.Entity("Ogrenc.Entities.Ders", b =>
                {
                    b.HasOne("Ogrenc.Entities.Bolum", "Bolum")
                        .WithMany("BolumDersleris")
                        .HasForeignKey("IdBolum");

                    b.HasOne("Ogrenc.Entities.OgretimElemani", "OgretimElemani")
                        .WithMany("DersVerilen")
                        .HasForeignKey("IdOgretimElemani");

                    b.Navigation("Bolum");

                    b.Navigation("OgretimElemani");
                });

            modelBuilder.Entity("Ogrenc.Entities.Ogrenci", b =>
                {
                    b.HasOne("Ogrenc.Entities.Bolum", "Anadal")
                        .WithMany("AnaDalOgrencileris")
                        .HasForeignKey("AnaDalId");

                    b.HasOne("Ogrenc.Entities.Bolum", "Yandal")
                        .WithMany("YanDalOgrencileris")
                        .HasForeignKey("YanDalId");

                    b.Navigation("Anadal");

                    b.Navigation("Yandal");
                });

            modelBuilder.Entity("Ogrenc.Entities.OgretimElemani", b =>
                {
                    b.HasOne("Ogrenc.Entities.Bolum", "Bolum")
                        .WithMany("BolumOgretimElemanlaris")
                        .HasForeignKey("idBolum")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bolum");
                });

            modelBuilder.Entity("Ogrenc.Entities.Bolum", b =>
                {
                    b.Navigation("AnaDalOgrencileris");

                    b.Navigation("BolumDersleris");

                    b.Navigation("BolumOgretimElemanlaris");

                    b.Navigation("YanDalOgrencileris");
                });

            modelBuilder.Entity("Ogrenc.Entities.OgretimElemani", b =>
                {
                    b.Navigation("DersVerilen");
                });
#pragma warning restore 612, 618
        }
    }
}
