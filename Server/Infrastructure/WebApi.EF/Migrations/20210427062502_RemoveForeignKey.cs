using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.EF.Migrations
{
    public partial class RemoveForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SALER_ADDRESS_SALER_INFO_SalerId",
                schema: "SALER",
                table: "SALER_ADDRESS");

            migrationBuilder.DropForeignKey(
                name: "FK_SALER_SCORE_SALER_INFO_SalerId",
                schema: "SALER",
                table: "SALER_SCORE");

            migrationBuilder.DropIndex(
                name: "IX_SALER_SCORE_SalerId",
                schema: "SALER",
                table: "SALER_SCORE");

            migrationBuilder.DropIndex(
                name: "IX_SALER_ADDRESS_SalerId",
                schema: "SALER",
                table: "SALER_ADDRESS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SALER_SCORE_SalerId",
                schema: "SALER",
                table: "SALER_SCORE",
                column: "SalerId");

            migrationBuilder.CreateIndex(
                name: "IX_SALER_ADDRESS_SalerId",
                schema: "SALER",
                table: "SALER_ADDRESS",
                column: "SalerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SALER_ADDRESS_SALER_INFO_SalerId",
                schema: "SALER",
                table: "SALER_ADDRESS",
                column: "SalerId",
                principalSchema: "SALER",
                principalTable: "SALER_INFO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SALER_SCORE_SALER_INFO_SalerId",
                schema: "SALER",
                table: "SALER_SCORE",
                column: "SalerId",
                principalSchema: "SALER",
                principalTable: "SALER_INFO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
