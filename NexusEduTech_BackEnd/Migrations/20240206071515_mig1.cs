using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NexusEduTech_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_classess",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_classess", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_CustomUser",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    FName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    LName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    DOB = table.Column<DateTime>(type: "Date", nullable: false),
                    Address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CustomUser", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_UserAuthenticate",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    role = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserAuthenticate", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Exam",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    ExamName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    ExamDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Max_Mark = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Exam", x => x.ExamId);
                    table.ForeignKey(
                        name: "FK_tbl_Exam_tbl_classess_ClassId",
                        column: x => x.ClassId,
                        principalTable: "tbl_classess",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClassRoomId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    RegistrationNumber = table.Column<string>(name: "Registration Number", type: "varchar(50)", maxLength: 50, nullable: false),
                    Std = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    Section = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_tbl_Student_tbl_CustomUser_UserId",
                        column: x => x.UserId,
                        principalTable: "tbl_CustomUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Student_tbl_classess_ClassId",
                        column: x => x.ClassId,
                        principalTable: "tbl_classess",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Teacher",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationNumber = table.Column<string>(name: "Registration Number", type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Teacher", x => x.TeacherId);
                    table.ForeignKey(
                        name: "FK_tbl_Teacher_tbl_CustomUser_UserId",
                        column: x => x.UserId,
                        principalTable: "tbl_CustomUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Teacher_tbl_classess_ClassId",
                        column: x => x.ClassId,
                        principalTable: "tbl_classess",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_tbl_Exam_ClassId",
                table: "tbl_Exam",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Marks_StudentId",
                table: "tbl_Marks",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Student_ClassId",
                table: "tbl_Student",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Student_UserId",
                table: "tbl_Student",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Teacher_ClassId",
                table: "tbl_Teacher",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Teacher_UserId",
                table: "tbl_Teacher",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Exam");

            migrationBuilder.DropTable(
                name: "tbl_Marks");

            migrationBuilder.DropTable(
                name: "tbl_Teacher");

            migrationBuilder.DropTable(
                name: "tbl_UserAuthenticate");

            migrationBuilder.DropTable(
                name: "tbl_Student");

            migrationBuilder.DropTable(
                name: "tbl_CustomUser");

            migrationBuilder.DropTable(
                name: "tbl_classess");
        }
    }
}
