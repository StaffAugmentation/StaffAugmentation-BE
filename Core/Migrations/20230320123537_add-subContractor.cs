using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    /// <inheritdoc />
    public partial class addsubContractor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubContractor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubContBa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubContBicsw = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubContVatRate = table.Column<double>(type: "float", nullable: true),
                    IsOfficial = table.Column<bool>(type: "bit", nullable: false),
                    IdApproverSub = table.Column<int>(type: "int", nullable: true),
                    LegalEntityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalEntityAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPaymentTerm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTypeOfCost = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubContractor", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubContractor");
        }
    }
}
