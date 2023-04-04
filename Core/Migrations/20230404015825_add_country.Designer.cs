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
    [Migration("20230404015825_add_country")]
    partial class add_country
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Model.Approver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("app_FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("app_LastName");

                    b.HasKey("Id");

                    b.ToTable("Approvers");
                });

            modelBuilder.Entity("Core.Model.BrSource", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("IdSource");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SourceName");

                    b.HasKey("Id");

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

                    b.ToTable("TypeBR");
                });

            modelBuilder.Entity("Core.Model.Category", b =>
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

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Core.Model.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCompany");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BICSW")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cmp_BICSW");

                    b.Property<string>("BankAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Cmp_Email");

                    b.Property<int?>("IdApprover")
                        .HasColumnType("int")
                        .HasColumnName("idApproverCmp");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEveris")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CompanyName");

                    b.Property<string>("VatLegalEntity")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cmp_VATLegalEntity");

                    b.Property<double?>("VatRate")
                        .HasColumnType("float")
                        .HasColumnName("cmp_VAT_Rate");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Core.Model.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("DailyAllowance")
                        .HasColumnType("float")
                        .HasColumnName("Daily_Allowance");

                    b.Property<double?>("HotelCeiling")
                        .HasColumnType("float")
                        .HasColumnName("Hotel_Ceiling");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Countries");
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

            modelBuilder.Entity("Core.Model.HighestDegree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ValueId");

                    b.HasKey("Id");

                    b.ToTable("ConsultantDegree");
                });

            modelBuilder.Entity("Core.Model.Level", b =>
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

                    b.ToTable("Level");
                });

            modelBuilder.Entity("Core.Model.OERPCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OERPCodeValue");

                    b.HasKey("Id");

                    b.ToTable("SA_OERPCodes");
                });

            modelBuilder.Entity("Core.Model.PTMOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BA")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PTMOwner_BA");

                    b.Property<string>("BICSW")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PTMOwner_BICSW");

                    b.Property<int?>("IdApprover")
                        .HasColumnType("int")
                        .HasColumnName("IdApproverPTMOwner");

                    b.Property<bool>("IsEveris")
                        .HasColumnType("bit");

                    b.Property<string>("ValueId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VatNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PTMOwner_VAT_Number");

                    b.Property<double?>("VatRate")
                        .HasColumnType("float")
                        .HasColumnName("PTMOwner_VAT_Rate");

                    b.HasKey("Id");

                    b.ToTable("PTMOwner");
                });

            modelBuilder.Entity("Core.Model.PaymentTerm", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PaymentTermValue");

                    b.HasKey("Id");

                    b.ToTable("PaymentTerms");
                });

            modelBuilder.Entity("Core.Model.PlaceOfDelivery", b =>
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

                    b.ToTable("PlaceOfDelivery");
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

            modelBuilder.Entity("Core.Model.RecruitmentResponsible", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ResponsibleEmail");

                    b.Property<bool>("IsPartner")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ResponsibleName");

                    b.Property<int?>("TypeOfContractId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Recruitment_Resp");
                });

            modelBuilder.Entity("Core.Model.RequestFormStatus", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ValueId");

                    b.HasKey("Id");

                    b.ToTable("RequestFormStatus");
                });

            modelBuilder.Entity("Core.Model.SubContractor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BA")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SubCont_BA");

                    b.Property<string>("BICSW")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SubCont_BICSW");

                    b.Property<int?>("IdApprover")
                        .HasColumnType("int")
                        .HasColumnName("idApproverSub");

                    b.Property<string>("IdNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ID_Number");

                    b.Property<string>("IdPaymentTerm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdTypeOfCost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOfficial")
                        .HasColumnType("bit");

                    b.Property<string>("LegalEntityAddress")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LegalEntityAdress");

                    b.Property<string>("LegalEntityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValueId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VatNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VAT_Number");

                    b.Property<double?>("VatRate")
                        .HasColumnType("float")
                        .HasColumnName("SubCont_VAT_Rate");

                    b.HasKey("Id");

                    b.ToTable("SubContractor");
                });

            modelBuilder.Entity("Core.Model.Type", b =>
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

                    b.ToTable("Type");
                });

            modelBuilder.Entity("Core.Model.TypeOfCost", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TypeOfCostValue");

                    b.HasKey("Id");

                    b.ToTable("TypeOfCost");
                });
#pragma warning restore 612, 618
        }
    }
}
