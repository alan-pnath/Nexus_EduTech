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
                name: "tbl_class",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    Standard = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Section = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_class", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_subjects",
                columns: table => new
                {
                    subjectId = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_subjects", x => x.subjectId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Role = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    ContactNumber = table.Column<string>(name: "Contact Number", type: "varchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    RegistrationNumber = table.Column<string>(name: "Registration Number", type: "varchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    DOB = table.Column<DateTime>(type: "Date", nullable: false),
                    Address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_tbl_Student_tbl_class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "tbl_class",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Teacher",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    DOB = table.Column<DateTime>(type: "Date", nullable: false),
                    Address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ContactNumber = table.Column<string>(name: "Contact Number", type: "varchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Teacher", x => x.TeacherId);
                    table.ForeignKey(
                        name: "FK_tbl_Teacher_tbl_class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "tbl_class",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Exam",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    ExamName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    ExamDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Max_Mark = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Exam", x => x.ExamId);
                    table.ForeignKey(
                        name: "FK_tbl_Exam_tbl_class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "tbl_class",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Exam_tbl_subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "tbl_subjects",
                        principalColumn: "subjectId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "scheduleClass",
                columns: table => new
                {
                    ScheduleClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    SessionTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SessionDate = table.Column<DateTime>(type: "date", nullable: false),
                    subjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scheduleClass", x => x.ScheduleClassId);
                    table.ForeignKey(
                        name: "FK_scheduleClass_tbl_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "tbl_Teacher",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_scheduleClass_tbl_class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "tbl_class",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_scheduleClass_tbl_subjects_subjectId",
                        column: x => x.subjectId,
                        principalTable: "tbl_subjects",
                        principalColumn: "subjectId",
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

            migrationBuilder.CreateTable(
                name: "tbl_Marks",
                columns: table => new
                {
                    MarkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    Mark = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Marks", x => x.MarkId);
                    table.ForeignKey(
                        name: "FK_tbl_Marks_tbl_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "tbl_Exam",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Marks_tbl_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "tbl_Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_scheduleClass_ClassId",
                table: "scheduleClass",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_scheduleClass_subjectId",
                table: "scheduleClass",
                column: "subjectId");

            migrationBuilder.CreateIndex(
                name: "IX_scheduleClass_TeacherId",
                table: "scheduleClass",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAttendences_StudentID",
                table: "StudentAttendences",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Exam_ClassId",
                table: "tbl_Exam",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Exam_SubjectId",
                table: "tbl_Exam",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Marks_ExamId",
                table: "tbl_Marks",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Marks_StudentId",
                table: "tbl_Marks",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Student_ClassId",
                table: "tbl_Student",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Teacher_ClassId",
                table: "tbl_Teacher",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherAttendences_TeacherId",
                table: "TeacherAttendences",
                column: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "scheduleClass");

            migrationBuilder.DropTable(
                name: "StudentAttendences");

            migrationBuilder.DropTable(
                name: "tbl_Marks");

            migrationBuilder.DropTable(
                name: "tbl_User");

            migrationBuilder.DropTable(
                name: "TeacherAttendences");

            migrationBuilder.DropTable(
                name: "tbl_Exam");

            migrationBuilder.DropTable(
                name: "tbl_Student");

            migrationBuilder.DropTable(
                name: "tbl_Teacher");

            migrationBuilder.DropTable(
                name: "tbl_subjects");

            migrationBuilder.DropTable(
                name: "tbl_class");
        }
    }
}
