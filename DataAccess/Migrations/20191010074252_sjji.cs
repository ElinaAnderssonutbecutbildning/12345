using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class sjji : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionAnswers",
                columns: table => new
                {
                    QuestionAnwID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionAnsText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAnswers", x => x.QuestionAnwID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherID);
                });

            migrationBuilder.CreateTable(
                name: "AnswerAlts",
                columns: table => new
                {
                    AnswerAltID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionAnswerID = table.Column<int>(nullable: false),
                    AlterText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerAlts", x => x.AnswerAltID);
                    table.ForeignKey(
                        name: "FK_AnswerAlts_QuestionAnswers_QuestionAnswerID",
                        column: x => x.QuestionAnswerID,
                        principalTable: "QuestionAnswers",
                        principalColumn: "QuestionAnwID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestAnswers",
                columns: table => new
                {
                    TestAnswerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerID = table.Column<int>(nullable: false),
                    QuestionAnwID = table.Column<int>(nullable: false),
                    QuestionAnswerQuestionAnwID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestAnswers", x => x.TestAnswerID);
                    table.ForeignKey(
                        name: "FK_TestAnswers_QuestionAnswers_QuestionAnswerQuestionAnwID",
                        column: x => x.QuestionAnswerQuestionAnwID,
                        principalTable: "QuestionAnswers",
                        principalColumn: "QuestionAnwID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerAltID = table.Column<int>(nullable: false),
                    QuestionAnwID = table.Column<int>(nullable: false),
                    QuestionName = table.Column<string>(nullable: true),
                    QuestionAnswerQuestionAnwID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionID);
                    table.ForeignKey(
                        name: "FK_Questions_AnswerAlts_AnswerAltID",
                        column: x => x.AnswerAltID,
                        principalTable: "AnswerAlts",
                        principalColumn: "AnswerAltID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_QuestionAnswers_QuestionAnswerQuestionAnwID",
                        column: x => x.QuestionAnswerQuestionAnwID,
                        principalTable: "QuestionAnswers",
                        principalColumn: "QuestionAnwID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAnswerID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Students_TestAnswers_TestAnswerID",
                        column: x => x.TestAnswerID,
                        principalTable: "TestAnswers",
                        principalColumn: "TestAnswerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    TestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionID = table.Column<int>(nullable: false),
                    TestName = table.Column<string>(nullable: true),
                    TestAnswerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.TestID);
                    table.ForeignKey(
                        name: "FK_Tests_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "QuestionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tests_TestAnswers_TestAnswerID",
                        column: x => x.TestAnswerID,
                        principalTable: "TestAnswers",
                        principalColumn: "TestAnswerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    TeacherID = table.Column<int>(nullable: false),
                    TestID = table.Column<int>(nullable: false),
                    Room = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Tests_TestID",
                        column: x => x.TestID,
                        principalTable: "Tests",
                        principalColumn: "TestID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    GradeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(nullable: false),
                    StudentID = table.Column<int>(nullable: false),
                    GradeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.GradeID);
                    table.ForeignKey(
                        name: "FK_Grades_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerAlts_QuestionAnswerID",
                table: "AnswerAlts",
                column: "QuestionAnswerID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherID",
                table: "Courses",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TestID",
                table: "Courses",
                column: "TestID");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_CourseID",
                table: "Grades",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentID",
                table: "Grades",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_AnswerAltID",
                table: "Questions",
                column: "AnswerAltID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionAnswerQuestionAnwID",
                table: "Questions",
                column: "QuestionAnswerQuestionAnwID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TestAnswerID",
                table: "Students",
                column: "TestAnswerID");

            migrationBuilder.CreateIndex(
                name: "IX_TestAnswers_QuestionAnswerQuestionAnwID",
                table: "TestAnswers",
                column: "QuestionAnswerQuestionAnwID");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_QuestionID",
                table: "Tests",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_TestAnswerID",
                table: "Tests",
                column: "TestAnswerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "TestAnswers");

            migrationBuilder.DropTable(
                name: "AnswerAlts");

            migrationBuilder.DropTable(
                name: "QuestionAnswers");
        }
    }
}
