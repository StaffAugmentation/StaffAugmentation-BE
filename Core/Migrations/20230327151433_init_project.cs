using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    /// <inheritdoc />
    public partial class init_project : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Approvers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    app_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    app_LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approvers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BrSource",
                columns: table => new
                {
                    IdSource = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrSource", x => x.IdSource);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    IdCompany = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEveris = table.Column<bool>(type: "bit", nullable: false),
                    cmp_VATLegalEntity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cmp_BICSW = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cmp_VAT_Rate = table.Column<double>(type: "float", nullable: true),
                    idApproverCmp = table.Column<int>(type: "int", nullable: true),
                    Cmp_Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.IdCompany);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Level",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTerms",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PaymentTermValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTerms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaceOfDelivery",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceOfDelivery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PTMOwner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PTMOwner_BA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PTMOwner_BICSW = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PTMOwner_VAT_Rate = table.Column<double>(type: "float", nullable: true),
                    IsEveris = table.Column<bool>(type: "bit", nullable: false),
                    IdApprover = table.Column<int>(type: "int", nullable: true),
                    PTMOwner_VAT_Number = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PTMOwner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestFormStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestFormStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubContractor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCont_BA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCont_BICSW = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCont_VAT_Rate = table.Column<double>(type: "float", nullable: true),
                    IsOfficial = table.Column<bool>(type: "bit", nullable: false),
                    idApproverSub = table.Column<int>(type: "int", nullable: true),
                    LegalEntityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalEntityAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VAT_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPaymentTerm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTypeOfCost = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubContractor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeBR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeBR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfCost",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TypeOfCostValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfCost", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Approvers");

            migrationBuilder.DropTable(
                name: "BrSource");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Level");

            migrationBuilder.DropTable(
                name: "PaymentTerms");

            migrationBuilder.DropTable(
                name: "PlaceOfDelivery");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropTable(
                name: "PTMOwner");

            migrationBuilder.DropTable(
                name: "RequestFormStatus");

            migrationBuilder.DropTable(
                name: "SubContractor");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropTable(
                name: "TypeBR");

            migrationBuilder.DropTable(
                name: "TypeOfCost");
        }
    }
}
