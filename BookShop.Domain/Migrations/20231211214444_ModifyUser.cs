using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShop.Domain.Migrations
{
    public partial class ModifyUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Iterations",
                table: "User");

            migrationBuilder.DropPrimaryKey(
         name: "PK_User",
         table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "User",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,0)")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
     name: "PK_User",
     table: "User",
     column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
 name: "PK_User",
 table: "User",
 column: "Id");

            migrationBuilder.AlterColumn<decimal>(
                name: "Id",
                table: "User",
                type: "numeric(18,0)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.DropPrimaryKey(
         name: "PK_User",
         table: "User");

            migrationBuilder.AddColumn<int>(
                name: "Iterations",
                table: "User",
                type: "int",
                nullable: true);
        }
    }
}
