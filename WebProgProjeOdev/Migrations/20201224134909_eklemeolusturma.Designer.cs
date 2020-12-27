﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebProgProjeOdev.Models;

namespace WebProgProjeOdev.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201224134909_eklemeolusturma")]
    partial class eklemeolusturma
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("WebProgProjeOdev.Models.AnalogFotograf", b =>
                {
                    b.Property<int>("AnalogFotografID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FotografAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotografKonum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("analogMakineID")
                        .HasColumnType("int");

                    b.HasKey("AnalogFotografID");

                    b.HasIndex("analogMakineID");

                    b.ToTable("AnalogFotografs");
                });

            modelBuilder.Entity("WebProgProjeOdev.Models.AnalogMakine", b =>
                {
                    b.Property<int>("AnalogMakineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("MakineAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("detay")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnalogMakineID");

                    b.ToTable("AnalogMakines");
                });

            modelBuilder.Entity("WebProgProjeOdev.Models.AnalogFotograf", b =>
                {
                    b.HasOne("WebProgProjeOdev.Models.AnalogMakine", "analogMakine")
                        .WithMany("AnalogFotografs")
                        .HasForeignKey("analogMakineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("analogMakine");
                });

            modelBuilder.Entity("WebProgProjeOdev.Models.AnalogMakine", b =>
                {
                    b.Navigation("AnalogFotografs");
                });
#pragma warning restore 612, 618
        }
    }
}
