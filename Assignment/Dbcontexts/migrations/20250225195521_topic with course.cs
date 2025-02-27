using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Dbcontexts.migrations
{
    /// <inheritdoc />
    public partial class topicwithcourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "topics");

            migrationBuilder.RenameColumn(
                name: "Top_ID",
                table: "Courses",
                newName: "Topic_Id");

            migrationBuilder.AddColumn<string>(
                name: "Topic_Name",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Topic_Name",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Topic_Id",
                table: "Courses",
                newName: "Top_ID");

            migrationBuilder.CreateTable(
                name: "topics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topics", x => x.Id);
                });
        }
    }
}
