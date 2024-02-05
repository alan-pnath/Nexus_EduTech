using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NexusEduTech_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_tbl_classess_ClassId",
                table: "Exams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exams",
                table: "Exams");

            migrationBuilder.RenameTable(
                name: "Exams",
                newName: "tbl_Exam");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_ClassId",
                table: "tbl_Exam",
                newName: "IX_tbl_Exam_ClassId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Exam",
                table: "tbl_Exam",
                column: "ExamId");

            migrationBuilder.CreateTable(
                name: "tbl_Marks",
                columns: table => new
                {
                    MarkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    Mark = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Marks", x => x.MarkId);
                    table.ForeignKey(
                        name: "FK_tbl_Marks_tbl_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "tbl_Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Marks_StudentId",
                table: "tbl_Marks",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Exam_tbl_classess_ClassId",
                table: "tbl_Exam",
                column: "ClassId",
                principalTable: "tbl_classess",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Exam_tbl_classess_ClassId",
                table: "tbl_Exam");

            migrationBuilder.DropTable(
                name: "tbl_Marks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Exam",
                table: "tbl_Exam");

            migrationBuilder.RenameTable(
                name: "tbl_Exam",
                newName: "Exams");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Exam_ClassId",
                table: "Exams",
                newName: "IX_Exams_ClassId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exams",
                table: "Exams",
                column: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_tbl_classess_ClassId",
                table: "Exams",
                column: "ClassId",
                principalTable: "tbl_classess",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
