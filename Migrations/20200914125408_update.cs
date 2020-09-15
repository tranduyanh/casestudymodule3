using Microsoft.EntityFrameworkCore.Migrations;

namespace SkateShop.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductViewModel",
                table: "ProductViewModel");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "ProductViewModel",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductViewModel",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductViewModel",
                table: "ProductViewModel",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductViewModel",
                table: "ProductViewModel");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductViewModel");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "ProductViewModel",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductViewModel",
                table: "ProductViewModel",
                column: "ProductName");
        }
    }
}
