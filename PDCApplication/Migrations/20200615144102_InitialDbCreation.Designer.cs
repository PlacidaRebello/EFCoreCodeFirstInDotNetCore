﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PDCApplication.Models;

namespace PDCApplication.Migrations
{
    [DbContext(typeof(DealManagementContext))]
    [Migration("20200615144102_InitialDbCreation")]
    partial class InitialDbCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PDCApplication.Models.Contact", b =>
                {
                    b.Property<string>("ContactId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("PDCApplication.Models.Deal", b =>
                {
                    b.Property<string>("DealId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Amount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CloseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DealId");

                    b.HasIndex("ContactId");

                    b.HasIndex("PropertyId");

                    b.ToTable("Deal");
                });

            modelBuilder.Entity("PDCApplication.Models.Property", b =>
                {
                    b.Property<string>("PropertyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BldgSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PropertyId");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("PDCApplication.Models.Deal", b =>
                {
                    b.HasOne("PDCApplication.Models.Contact", "Contact")
                        .WithMany("Deals")
                        .HasForeignKey("ContactId");

                    b.HasOne("PDCApplication.Models.Property", "Property")
                        .WithMany("Deals")
                        .HasForeignKey("PropertyId");
                });
#pragma warning restore 612, 618
        }
    }
}
