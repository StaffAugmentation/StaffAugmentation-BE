﻿// <auto-generated />
using System;
using Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Core.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230320123537_add-subContractor")]
    partial class addsubContractor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Model.Approvers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AppFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Approvers");
                });

            modelBuilder.Entity("Core.Model.BrSource", b =>
                {
                    b.Property<string>("IdSource")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SourceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSource");

                    b.ToTable("BrSource");
                });

            modelBuilder.Entity("Core.Model.BrType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ValueId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BrType");
                });

            modelBuilder.Entity("Core.Model.Company", b =>
                {
                    b.Property<int>("IdCompany")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCompany"));

                    b.Property<string>("BankAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CmpBicsw")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CmpEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("CmpVatRate")
                        .HasColumnType("float");

                    b.Property<string>("CmpVatlegalEntity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdApproverCmp")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEveris")
                        .HasColumnType("bit");

                    b.HasKey("IdCompany");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Core.Model.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ValueId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("Core.Model.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ValueId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("Core.Model.SubContractor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdApproverSub")
                        .HasColumnType("int");

                    b.Property<string>("IdNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdPaymentTerm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdTypeOfCost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOfficial")
                        .HasColumnType("bit");

                    b.Property<string>("LegalEntityAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalEntityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubContBa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubContBicsw")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("SubContVatRate")
                        .HasColumnType("float");

                    b.Property<string>("ValueId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VatNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SubContractor");
                });
#pragma warning restore 612, 618
        }
    }
}
