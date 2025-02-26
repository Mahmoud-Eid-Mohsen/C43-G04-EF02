using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Dbcontexts.migrations
{
    /// <inheritdoc />
    public partial class o2mrealtionin2dept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MgID",
                table: "Departments");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_Dept_ID",
                table: "instructors",
                column: "Dept_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_Departments_Dept_ID",
                table: "instructors",
                column: "Dept_ID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_instructors_Departments_Dept_ID",
                table: "instructors");

            migrationBuilder.DropIndex(
                name: "IX_instructors_Dept_ID",
                table: "instructors");

            migrationBuilder.AddColumn<int>(
                name: "MgID",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
