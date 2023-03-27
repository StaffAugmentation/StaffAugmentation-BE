using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    /// <inheritdoc />
    public partial class add_recruitmentResp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecruitmentResp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResponsibleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsibleEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPartner = table.Column<bool>(type: "bit", nullable: false),
                    TypeOfContractId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecruitmentResp", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecruitmentResp");
        }
    }
}
