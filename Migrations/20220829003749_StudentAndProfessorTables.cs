using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_NetRazor.Migrations
{
    public partial class StudentAndProfessorTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date_birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Specialty = table.Column<int>(type: "int", nullable: false),
                    Admission_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date_birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    number_of_courses = table.Column<int>(type: "int", nullable: false),
                    Admission_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Admission_hour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Eggres_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Professor");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
