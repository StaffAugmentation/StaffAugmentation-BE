using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    /// <inheritdoc />
    public partial class add_ptmOwner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PTMOwner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PTMOwnerBA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PTMOwnerBICSW = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PTMOwnerVatRate = table.Column<double>(type: "float", nullable: true),
                    IsEveris = table.Column<bool>(type: "bit", nullable: false),
                    IdApprover = table.Column<int>(type: "int", nullable: true),
                    PTMOwnerVatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PTMOwner", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PTMOwner");
        }
    }
}
