using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduConnect.Migrations
{
    public partial class AddingKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestTable",
                table: "RequestTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HiringForm",
                table: "HiringForm");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "RequestTable",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "HiringForm",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestTable",
                table: "RequestTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HiringForm",
                table: "HiringForm",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestTable",
                table: "RequestTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HiringForm",
                table: "HiringForm");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "RequestTable");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "HiringForm");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestTable",
                table: "RequestTable",
                column: "Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HiringForm",
                table: "HiringForm",
                column: "Email");
        }
    }
}
