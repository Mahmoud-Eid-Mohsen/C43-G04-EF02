using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Dbcontexts.migrations
{
    /// <inheritdoc />
    public partial class createtablestudentcourseandm2mrealtions2c : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studunt_Course",
                columns: table => new
                {
                    studentID = table.Column<int>(type: "int", nullable: false),
                    courseID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studunt_Course", x => new { x.courseID, x.studentID });
                    table.ForeignKey(
                        name: "FK_Studunt_Course_Courses_courseID",
                        column: x => x.courseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Studunt_Course_Students_studentID",
                        column: x => x.studentID,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Studunt_Course_studentID",
                table: "Studunt_Course",
                column: "studentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studunt_Course");
        }
    }
}
