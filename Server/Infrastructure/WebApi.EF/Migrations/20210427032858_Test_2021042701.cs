using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.EF.Migrations
{
    public partial class Test_2021042701 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "SALER");

            migrationBuilder.CreateSequence(
                name: "SEQ_INFO_ID",
                schema: "SALER",
                incrementBy: 10);

            migrationBuilder.CreateTable(
                name: "SalerInfo",
                schema: "SALER",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    UserName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AccountId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalerInfo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalerInfo",
                schema: "SALER");

            migrationBuilder.DropSequence(
                name: "SEQ_INFO_ID",
                schema: "SALER");
        }
    }
}
