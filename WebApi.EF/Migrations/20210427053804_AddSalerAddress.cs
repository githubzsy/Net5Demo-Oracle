using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.EF.Migrations
{
    public partial class AddSalerAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "SEQ_INFO_ID",
                schema: "SALER");

            migrationBuilder.CreateSequence(
                name: "SEQ_SALER_ADDRESS_ID",
                schema: "SALER",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "SEQ_SALER_SCORE_ID",
                schema: "SALER",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "SEQ_SALERINFO_ID",
                schema: "SALER",
                incrementBy: 10);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "SALER",
                table: "SALER_SCORE",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)")
                .OldAnnotation("Oracle:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "SALER_ADDRESS",
                schema: "SALER",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Address = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SalerId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALER_ADDRESS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SALER_ADDRESS_SALER_INFO_SalerId",
                        column: x => x.SalerId,
                        principalSchema: "SALER",
                        principalTable: "SALER_INFO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "FK_SALER_SCORE_SALER_INFO_SalerId",
                schema: "SALER",
                table: "SALER_SCORE",
                column: "SalerId",
                principalSchema: "SALER",
                principalTable: "SALER_INFO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SALER_SCORE_SALER_INFO_SalerId",
                schema: "SALER",
                table: "SALER_SCORE");

            migrationBuilder.DropTable(
                name: "SALER_ADDRESS",
                schema: "SALER");

            migrationBuilder.DropIndex(
                name: "IX_SALER_SCORE_SalerId",
                schema: "SALER",
                table: "SALER_SCORE");

            migrationBuilder.DropSequence(
                name: "SEQ_SALER_ADDRESS_ID",
                schema: "SALER");

            migrationBuilder.DropSequence(
                name: "SEQ_SALER_SCORE_ID",
                schema: "SALER");

            migrationBuilder.DropSequence(
                name: "SEQ_SALERINFO_ID",
                schema: "SALER");

            migrationBuilder.CreateSequence(
                name: "SEQ_INFO_ID",
                schema: "SALER",
                incrementBy: 10);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "SALER",
                table: "SALER_SCORE",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)")
                .Annotation("Oracle:Identity", "1, 1");
        }
    }
}
