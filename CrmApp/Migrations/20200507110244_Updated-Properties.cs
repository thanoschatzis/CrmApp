using Microsoft.EntityFrameworkCore.Migrations;

namespace CrmApp.Migrations
{
    public partial class UpdatedProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "LastName",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
