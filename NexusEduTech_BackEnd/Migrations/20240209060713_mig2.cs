using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NexusEduTech_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentAttendences",
                columns: table => new
                {
                    StudAttendenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    StudentAttendenceDate = table.Column<DateTime>(type: "date", nullable: false),
                    StudentStatus = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAttendences", x => x.StudAttendenceId);
                    table.ForeignKey(
                        name: "FK_StudentAttendences_tbl_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "tbl_Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherAttendences",
                columns: table => new
                {
                    TeacherAttendId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    TeacherAttendenceDate = table.Column<DateTime>(type: "date", nullable: false),
                    TeacherStatus = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherAttendences", x => x.TeacherAttendId);
                    table.ForeignKey(
                        name: "FK_TeacherAttendences_tbl_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "tbl_Teacher",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentAttendences_StudentID",
                table: "StudentAttendences",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherAttendences_TeacherId",
                table: "TeacherAttendences",
                column: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentAttendences");

            migrationBuilder.DropTable(
                name: "TeacherAttendences");
        }
    }
}
