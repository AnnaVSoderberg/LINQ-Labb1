using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LINQ.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblCourses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCourses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TblTeachers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTeachers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TblStudents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CourseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblStudents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TblStudents_TblCourses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "TblCourses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblSubjects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModelCourseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSubjects", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TblSubjects_TblCourses_ModelCourseID",
                        column: x => x.ModelCourseID,
                        principalTable: "TblCourses",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ModelCourseModelTeacher",
                columns: table => new
                {
                    CoursesID = table.Column<int>(type: "int", nullable: false),
                    TeachersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelCourseModelTeacher", x => new { x.CoursesID, x.TeachersID });
                    table.ForeignKey(
                        name: "FK_ModelCourseModelTeacher_TblCourses_CoursesID",
                        column: x => x.CoursesID,
                        principalTable: "TblCourses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelCourseModelTeacher_TblTeachers_TeachersID",
                        column: x => x.TeachersID,
                        principalTable: "TblTeachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModelSubjectModelTeacher",
                columns: table => new
                {
                    SubjectsID = table.Column<int>(type: "int", nullable: false),
                    TeachersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelSubjectModelTeacher", x => new { x.SubjectsID, x.TeachersID });
                    table.ForeignKey(
                        name: "FK_ModelSubjectModelTeacher_TblSubjects_SubjectsID",
                        column: x => x.SubjectsID,
                        principalTable: "TblSubjects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelSubjectModelTeacher_TblTeachers_TeachersID",
                        column: x => x.TeachersID,
                        principalTable: "TblTeachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModelCourseModelTeacher_TeachersID",
                table: "ModelCourseModelTeacher",
                column: "TeachersID");

            migrationBuilder.CreateIndex(
                name: "IX_ModelSubjectModelTeacher_TeachersID",
                table: "ModelSubjectModelTeacher",
                column: "TeachersID");

            migrationBuilder.CreateIndex(
                name: "IX_TblStudents_CourseID",
                table: "TblStudents",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_TblSubjects_ModelCourseID",
                table: "TblSubjects",
                column: "ModelCourseID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelCourseModelTeacher");

            migrationBuilder.DropTable(
                name: "ModelSubjectModelTeacher");

            migrationBuilder.DropTable(
                name: "TblStudents");

            migrationBuilder.DropTable(
                name: "TblSubjects");

            migrationBuilder.DropTable(
                name: "TblTeachers");

            migrationBuilder.DropTable(
                name: "TblCourses");
        }
    }
}
