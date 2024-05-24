using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduConnect.Migrations
{
    public partial class EduConnectDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HiringForm",
                columns: table => new
                {
                    Email = table.Column<string>(type: "varchar(20)", nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false),
                    TutorCode = table.Column<string>(type: "varchar(20)", nullable: false),
                    Message = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HiringForm", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "RequestTable",
                columns: table => new
                {
                    Email = table.Column<string>(type: "varchar(20)", nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false),
                    Request = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestTable", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(type: "varchar(20)", nullable: false),
                    Qualification = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HiringForm");

            migrationBuilder.DropTable(
                name: "RequestTable");

            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
