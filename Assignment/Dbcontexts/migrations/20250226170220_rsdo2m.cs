using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Dbcontexts.migrations
{
    /// <inheritdoc />
    public partial class rsdo2m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_instructors_Departments_Dept_ID",
                table: "instructors");

            migrationBuilder.DropColumn(
                name: "Dep_Id",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "Dept_ID",
                table: "instructors",
                newName: "DepartmentsID");

            migrationBuilder.RenameIndex(
                name: "IX_instructors_Dept_ID",
                table: "instructors",
                newName: "IX_instructors_DepartmentsID");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentId",
                table: "Students",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_Departments_DepartmentsID",
                table: "instructors",
                column: "DepartmentsID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_instructors_Departments_DepartmentsID",
                table: "instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "DepartmentsID",
                table: "instructors",
                newName: "Dept_ID");

            migrationBuilder.RenameIndex(
                name: "IX_instructors_DepartmentsID",
                table: "instructors",
                newName: "IX_instructors_Dept_ID");

            migrationBuilder.AddColumn<int>(
                name: "Dep_Id",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_Departments_Dept_ID",
                table: "instructors",
                column: "Dept_ID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
