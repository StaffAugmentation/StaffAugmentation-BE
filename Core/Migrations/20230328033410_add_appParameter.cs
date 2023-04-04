using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    /// <inheritdoc />
    public partial class add_appParameter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppParameter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QTMDailyPriceIsActive = table.Column<bool>(type: "bit", nullable: true),
                    TMDailyPriceIsActive = table.Column<bool>(type: "bit", nullable: true),
                    DaysBeforeDeletingFile = table.Column<int>(type: "int", nullable: true),
                    SAUrlAppProd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SAEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrAdvancedSearchDate = table.Column<int>(type: "int", nullable: true),
                    SCAdvancedSearchPeriod = table.Column<int>(type: "int", nullable: true),
                    HREmailSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HREmailText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsultantEmailSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsultantEmailText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SAVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseLDAPService = table.Column<bool>(type: "bit", nullable: true),
                    ContractApprover = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractApproverEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppParameter", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppParameter");
        }
    }
}
