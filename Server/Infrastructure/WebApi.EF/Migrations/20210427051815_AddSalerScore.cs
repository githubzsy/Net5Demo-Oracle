using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.EF.Migrations
{
    public partial class AddSalerScore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SalerInfo",
                schema: "SALER",
                table: "SalerInfo");

            migrationBuilder.RenameTable(
                name: "SalerInfo",
                schema: "SALER",
                newName: "SALER_INFO",
                newSchema: "SALER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SALER_INFO",
                schema: "SALER",
                table: "SALER_INFO",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SALER_SCORE",
                schema: "SALER",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    SalerId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Score = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALER_SCORE", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SALER_SCORE",
                schema: "SALER");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SALER_INFO",
                schema: "SALER",
                table: "SALER_INFO");

            migrationBuilder.RenameTable(
                name: "SALER_INFO",
                schema: "SALER",
                newName: "SalerInfo",
                newSchema: "SALER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalerInfo",
                schema: "SALER",
                table: "SalerInfo",
                column: "Id");
        }
    }
}
