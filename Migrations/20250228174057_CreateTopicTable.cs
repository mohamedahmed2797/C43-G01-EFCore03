using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C43_G01_EFCore03.Migrations
{
    /// <inheritdoc />
    public partial class CreateTopicTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_Topic_Top_IdId",
                table: "courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topic",
                table: "Topic");

            migrationBuilder.RenameTable(
                name: "Topic",
                newName: "Topics");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topics",
                table: "Topics",
                column: "Topic_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_Topics_Top_IdId",
                table: "courses",
                column: "Top_IdId",
                principalTable: "Topics",
                principalColumn: "Topic_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_Topics_Top_IdId",
                table: "courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topics",
                table: "Topics");

            migrationBuilder.RenameTable(
                name: "Topics",
                newName: "Topic");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topic",
                table: "Topic",
                column: "Topic_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_Topic_Top_IdId",
                table: "courses",
                column: "Top_IdId",
                principalTable: "Topic",
                principalColumn: "Topic_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
