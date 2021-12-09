﻿// <auto-generated />
using System;
using Applikacio2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Applikacio2.Migrations
{
    [DbContext(typeof(registryContext))]
    [Migration("20211208223036_change_account_entity")]
    partial class change_account_entity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Hungarian_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Applikacio2.Dokumentum", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("extension");

                    b.Property<int>("MainId")
                        .HasColumnType("int")
                        .HasColumnName("main_id");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("source");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("dokumentum");
                });

            modelBuilder.Entity("Applikacio2.Esemeny", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("esemeny");
                });

            modelBuilder.Entity("Applikacio2.Models.Account", b =>
                {
                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Username");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Password");

                    b.HasKey("Username");

                    b.ToTable("account");
                });

            modelBuilder.Entity("Applikacio2.Naplo", b =>
                {
                    b.Property<int>("DokumentumId")
                        .HasColumnType("int")
                        .HasColumnName("dokumentum_id");

                    b.Property<int>("EsemenyId")
                        .HasColumnType("int")
                        .HasColumnName("esemeny_id");

                    b.Property<DateTime>("HappenedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("happened_at");

                    b.HasKey("DokumentumId", "EsemenyId", "HappenedAt");

                    b.HasIndex("EsemenyId");

                    b.ToTable("naplo");
                });

            modelBuilder.Entity("Applikacio2.Naplo", b =>
                {
                    b.HasOne("Applikacio2.Dokumentum", "Dokumentum")
                        .WithMany("Naplos")
                        .HasForeignKey("DokumentumId")
                        .HasConstraintName("FK_naplo_dokumentum")
                        .IsRequired();

                    b.HasOne("Applikacio2.Esemeny", "Esemeny")
                        .WithMany("Naplos")
                        .HasForeignKey("EsemenyId")
                        .HasConstraintName("FK_naplo_esemeny")
                        .IsRequired();

                    b.Navigation("Dokumentum");

                    b.Navigation("Esemeny");
                });

            modelBuilder.Entity("Applikacio2.Dokumentum", b =>
                {
                    b.Navigation("Naplos");
                });

            modelBuilder.Entity("Applikacio2.Esemeny", b =>
                {
                    b.Navigation("Naplos");
                });
#pragma warning restore 612, 618
        }
    }
}